using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;

const string DIR = "ftp://ftp.unicode.org/Public/UNIDATA/";
const string UNICODE_DATA = DIR + "UnicodeData.txt";
const string COMPOSITION_EXCLUSIONS = DIR + "CompositionExclusions.txt";

// Called exactly once by NormalizerData to build the static data
class UChar
{
	readonly int codepoint;
	public bool IsCompatibility { get; set; }
	public bool IsExcluded { get; set; }
	public List<int> Decompose { get; set; } = new List<int>();
	public int CanonicalClass { get; set; }
	public SortedDictionary<int, int> ComposeTrie { get; set; } = new SortedDictionary<int, int>();
	public UChar(int cp)
	{
		this.codepoint = cp;
	}

	private string ToJson_flag() => (CanonicalClass | (IsCompatibility ? 1 << 8 : 0) | (IsExcluded ? 1 << 9 : 0)).ToString();

	private string ToJson_decomp() => $"[{String.Join(",", Decompose)}]";

	private string ToJson_comp() => $"{{{String.Join(",", ComposeTrie.Select(x => $"{x.Key}:{x.Value}"))}}}";

	public string ToJson()
	{
		var flagStr = ToJson_flag();
		var decompStr = ToJson_decomp();
		var compStr = ToJson_comp();
		
		var props = new List<string>();

		props.Add(Decompose.Any() ? decompStr : "");
		props.Add(flagStr != "0" ? flagStr : "");
		props.Add(ComposeTrie.Any() ? compStr : "");

		// Trim right
		for (int i = props.Count - 1; i >= 0; i--)
		{
			if (props[i] == "")
			{
				props.RemoveAt(i);
			}
			else break;
		}

		return $"{codepoint}:[{String.Join(",", props)}]";
	}

	static SortedDictionary<int, UChar> cmap = new SortedDictionary<int, UChar>();
	
	public static UChar getUChar(int cp)
	{
		UChar ret;
		if (!cmap.TryGetValue(cp, out ret))
		{
			ret = new UChar(cp);
			cmap.Add(cp, ret);
		}
		return ret;
	}

	public static String ToJsonAll()
	{
		return $@"{{{"\n"}{
			String.Join
			(
				",\n",
				cmap.Values
					.Where(uc => !(uc.CanonicalClass == 0 && !uc.IsCompatibility && !uc.IsExcluded && !uc.Decompose.Any() && !uc.ComposeTrie.Any()))
					.GroupBy(uc => (uc.codepoint >> 8) & 0xFF)
					.OrderBy(g => g.Key)
					.Select(g => $"{g.Key << 8}:{{{String.Join(",", g.Select(uc => uc.ToJson()))}}}")
			)
		}{"\n"}}}";
	}
}

static readonly Regex codepointRegex = new Regex("[^\\da-fA-F]");

// =============================================================
// Building Decomposition Tables
// =============================================================

// Reads exclusion list and stores the data
private static void ReadExclusionList()
{
	var request = (FtpWebRequest)FtpWebRequest.Create(new Uri(COMPOSITION_EXCLUSIONS));
	request.UsePassive = false;
	request.UseBinary = true;
	request.Method = WebRequestMethods.Ftp.DownloadFile;
	using (var response = (FtpWebResponse)request.GetResponse())
	using (var stream = response.GetResponseStream())
	using (var reader = new StreamReader(stream))
	{
		string line;
		while ((line = reader.ReadLine()) != null)
		{
			line = line.Split('#')[0];
			if (line == "") continue;

			// store -1 in the excluded table for each character hit
			var value = int.Parse(codepointRegex.Split(line)[0], NumberStyles.HexNumber);
			UChar.getUChar(value).IsExcluded = true;
		}
	}

	// workaround
	UChar.getUChar(0x0F81).IsExcluded = true;
	UChar.getUChar(0x0F73).IsExcluded = true;
	UChar.getUChar(0x0F75).IsExcluded = true;
}

// Builds a decomposition table from a UnicodeData file
private static void BuildDecompositionTables()
{

	var request = (FtpWebRequest)FtpWebRequest.Create(new Uri(UNICODE_DATA));
	request.UsePassive = false;
	request.UseBinary = true;
	request.Method = WebRequestMethods.Ftp.DownloadFile;
	using (var response = (FtpWebResponse)request.GetResponse())
	using (var stream = response.GetResponseStream())
	using (var reader = new StreamReader(stream))
	{
		string line;
		int value;
		int counter = 0;
		while ((line = reader.ReadLine()) != null)
		{
			line = line.Split('#')[0];
			if (line == "") continue;

			// find the values of the particular fields that we need
			// Sample line: 00C0;LATIN ...A GRAVE;Lu;0;L;0041 0300;;;;N;LATIN
			// ... GRAVE;;;00E0;

			int start = 0;
			int end = line.IndexOf(';'); // code
			value = int.Parse(codepointRegex.Split(line)[0], NumberStyles.HexNumber);
			UChar uchar = UChar.getUChar(value);
			end = line.IndexOf(';', start = end + 1); // name
			end = line.IndexOf(';', start = end + 1); // general category
			end = line.IndexOf(';', start = end + 1); // canonical class

			// check consistency: canonical classes must be from 0 to 255

			int cc = int.Parse(line.Substring(start, end - start));
			if (cc != (cc & 0xFF))
			{
				throw new InvalidOperationException("Bad canonical class at: " + line);
			}
			uchar.CanonicalClass = cc;
			end = line.IndexOf(';', start = end + 1); // BIDI
			end = line.IndexOf(';', start = end + 1); // decomp

			// decomp requires more processing.
			// store whether it is canonical or compatibility.
			// store the decomp in one table, and the reverse mapping (from
			// pairs) in another

			if (start != end)
			{
				String segment = line.Substring(start, end - start);
				bool compat = segment[0] == '<';
				if (compat)
				{
					uchar.IsCompatibility = true;
				}
				List<int> decomp = FromHex(segment);

				// check consistency: all canon decomps must be singles or
				// pairs!

				if (decomp.Count < 1 || decomp.Count > 2 && !compat)
				{
					throw new InvalidOperationException("Bad decomp at: " + line);
				}

				uchar.Decompose = decomp;

				// only compositions are canonical pairs
				// skip if script exclusion

				if (!compat && !uchar.IsExcluded && decomp.Count != 1)
				{
					// <decomp>とかの表記がない && 除外指定されていない && singletonでない
					UChar.getUChar(decomp[0]).ComposeTrie[decomp[1]] = value;
				}
			}
		}
	}
}

// Hangul composition constants
static readonly int SBase = 0xAC00, LBase = 0x1100, VBase = 0x1161, TBase = 0x11A7, LCount = 19, VCount = 21, TCount = 28,
	NCount = VCount * TCount, // 588
	SCount = LCount * NCount; // 11172

// Utility: Parses a sequence of hex Unicode characters separated by spaces
public static List<int> FromHex(string source)
{
	var result = new List<int>();
	for (int i = 0; i < source.Length; ++i)
	{
		char c = source[i];
		switch (c)
		{
			case ' ':
				break; // ignore
			case '0':
			case '1':
			case '2':
			case '3':
			case '4':
			case '5':
			case '6':
			case '7':
			case '8':
			case '9':
			case 'A':
			case 'B':
			case 'C':
			case 'D':
			case 'E':
			case 'F':
			case 'a':
			case 'b':
			case 'c':
			case 'd':
			case 'e':
			case 'f':
				string num = codepointRegex.Split(source.Substring(i))[0];
				result.Add(int.Parse(num, NumberStyles.HexNumber));
				i += num.Length - 1; // skip rest of number
				break;
			case '<':
				int j = source.IndexOf('>', i); // skip <...>
				if (j > 0)
				{
					i = j;
					break;
				} // else fall through--error
				goto default;
			default:
				throw new InvalidOperationException("Bad hex value in " + source);
		}
	}
	return result;
}

// ===============
//     Output
// ===============

ReadExclusionList();
BuildDecompositionTables();

Context.Output.WriteLine($@"
namespace UnicodeNormalization
{{
	internal partial class UChar
	{{
		private const string source = @""{UChar.ToJsonAll()}"";
	}}
}}
");