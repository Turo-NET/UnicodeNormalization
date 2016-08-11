using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using Endless;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace UnicodeNormalization
{
	internal class Feature
	{
		public int[] _0 { get; set; }
		public int? _1 { get; set; }
		public Dictionary<int, int> _2 { get; set; }
	}

	internal partial class UChar
	{
		static readonly Feature DEFAULT_FEATURE = new Feature { _0 = null, _1 = null, _2 = new Dictionary<int,int>() };
		const int CACHE_THRESHOLD = 10;
		const int SBase = 0xAC00, LBase = 0x1100, VBase = 0x1161, TBase = 0x11A7, LCount = 19, VCount = 21, TCount = 28;
		const int NCount = VCount * TCount; // 588
		const int SCount = LCount * NCount; // 11172

		public int Codepoint { get; set; }
		public Feature Feature { get; set; }

		public UChar(int cp, Feature feature)
		{
			this.Codepoint = cp;
			this.Feature = feature;
		}

		static WeakReference udata = new WeakReference(null);
		public static Dictionary<int, Dictionary<int, Feature>> UData
		{
			get
			{
				var value = udata.Target as Dictionary<int, Dictionary<int, Feature>>;
				if (value == null)
				{
					value = generateUData();
					udata = new WeakReference(value);
				}
				return value;
			}
		}

		private static Dictionary<int, Dictionary<int, Feature>> generateUData()
		{
			return JsonConvert.DeserializeObject<Dictionary<int, Dictionary<int, JArray>>>(source).ToDictionary
			(
				x => x.Key,
				x => x.Value.ToDictionary
				(
					y => y.Key,
					y => new Feature
					{
						_0 = y.Value == null ? null : y.Value[0].Type == JTokenType.Null ? null : y.Value[0].Select(jv => (int)jv).ToArray(),
						_1 = y.Value == null ? null : y.Value.Count < 2 ? null : y.Value[1].Type == JTokenType.Null ? null : (int?)y.Value[1],
						_2 = y.Value == null ? null : y.Value.Count < 3 ? null : ((JObject)y.Value[2]).ToObject<Dictionary<int, int>>()
					}
				)
			);
		}

		// Strategies
		static Dictionary<int, UChar> cache = new Dictionary<int, UChar>();
		static int[] cacheCounter = new int[256];

		static UChar FromCache(Func<int, bool, UChar> next, int cp, bool needFeature)
		{
			UChar ret;
			if (!cache.TryGetValue(cp, out ret))
			{
				ret = next(cp, needFeature);
				if (ret.Feature != null && ++cacheCounter[(cp >> 8) & 0xFF] > CACHE_THRESHOLD)
				{
					cache[cp] = ret;
				}
			}
			return ret;
		}
		static UChar FromData(Func<int, bool, UChar> next, int cp, bool needFeature)
		{
			int hash = cp & 0xFF00;
			Dictionary<int, Feature> dunit;
			if (!UChar.UData.TryGetValue(hash, out dunit))
				dunit = new Dictionary<int, Feature>();
			Feature f;
			return dunit.TryGetValue(cp, out f) ? new UChar(cp, f) : new UChar(cp, DEFAULT_FEATURE);
		}
		static UChar FromCpOnly(Func<int, bool, UChar> next, int cp, bool needFeature)
		{
			return needFeature ? next(cp, needFeature) : new UChar(cp, null);
		}
		static UChar FromRuleBasedJamo(Func<int, bool, UChar> next, int cp, bool needFeature)
		{
			int j;
			if (cp < LBase || (LBase + LCount <= cp && cp < SBase) || (SBase + SCount < cp))
			{
				return next(cp, needFeature);
			}
			if (LBase <= cp && cp < LBase + LCount)
			{
				var c = new Dictionary<int, int>();
				var @base = (cp - LBase) * VCount;
				for (j = 0; j < VCount; ++j)
				{
					c[VBase + j] = SBase + TCount * (j + @base);
				}
				return new UChar(cp, new Feature { _2 = c });
			}

			var SIndex = cp - SBase;
			var TIndex = SIndex % TCount;
			var feature = new Feature();
			if (TIndex != 0)
			{
				feature._0 = new int[] { SBase + SIndex - TIndex, TBase + TIndex };
			}
			else
			{
				feature._0 = new int[] { LBase + (int)Math.Floor(SIndex / NCount), VBase + (int)Math.Floor((SIndex % NCount) / TCount) };
				feature._2 = new Dictionary<int, int>();
				for (j = 1; j < TCount; ++j)
				{
					feature._2[TBase + j] = cp + j;
				}
			}
			return new UChar(cp, feature);
		}
		static UChar FromCpFilter(Func<int, bool, UChar> next, int cp, bool needFeature)
		{
			return cp < 60 || 13311 < cp && cp < 42607 ? new UChar(cp, DEFAULT_FEATURE) : next(cp, needFeature);
		}

		static List<Func<Func<int, bool, UChar>, int, bool, UChar>> strategies = new List<Func<Func<int, bool, UChar>, int, bool, UChar>>()
			{ FromCpFilter, FromCache, FromCpOnly, FromRuleBasedJamo, FromData };

		static Func<int, bool, UChar> fromCharCode =
			strategies.AggregateRight(default(Func<int, bool, UChar>), (strategy, next) =>
			{
				return (cp, needFeature) =>
				{
					return strategy(next, cp, needFeature);
				};
			});

		public static UChar FromCharCode(int cp, bool needFeature = false)
		{
			return fromCharCode(cp, needFeature);
		}

		public static bool IsHighSurrogate(int cp)
		{
			return cp >= 0xD800 && cp <= 0xDBFF;
		}
		public static bool IsLowSurrogate(int cp)
		{
			return cp >= 0xDC00 && cp <= 0xDFFF;
		}

		public void PrepFeature()
		{
			if (this.Feature == null)
			{
				this.Feature = UChar.FromCharCode(this.Codepoint, true).Feature;
			}
		}

		public override string ToString()
		{
			if (this.Codepoint < 0x10000)
			{
				return new string(new char[] { (char)this.Codepoint });
			}
			else
			{
				var x = this.Codepoint - 0x10000;
				return new string(new char[] { (char)((int)Math.Floor(x / 0x400) + 0xD800), (char)(x % 0x400 + 0xDC00) });
			}
		}

		public int[] Decomp
		{
			get
			{
				this.PrepFeature();
				return this.Feature._0;
			}
		}

		public bool IsCompatibility
		{
			get
			{
				this.PrepFeature();
				return this.Feature._1 != null && (this.Feature._1.Value & (1 << 8)) != 0;
			}
		}
		public bool IsExclude
		{
			get
			{
				this.PrepFeature();
				return this.Feature._1 != null && (this.Feature._1.Value & (1 << 9)) != 0;
			}
		}
		public int CanonicalClass
		{
			get
			{
				this.PrepFeature();
				return this.Feature._1 != null ? (this.Feature._1.Value & 0xFF) : 0;
			}
		}
		public UChar GetComposite(UChar following)
		{
			this.PrepFeature();
			if (this.Feature._2 == null)
			{
				return null;
			}
			int cp;
			return this.Feature._2.TryGetValue(following.Codepoint, out cp)
				? UChar.FromCharCode(cp)
				: null;
		}
	}
}