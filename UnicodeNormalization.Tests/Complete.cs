using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnicodeNormalization.Tests
{
	[TestClass]
	public class Complete
	{
		ConditionalWeakTable<List<List<int>>, string> lineInfo = new ConditionalWeakTable<List<List<int>>, string>();
		string utdata = File.ReadAllText("NormalizationTest.txt");
		List<List<List<int>>> tests = new List<List<List<int>>>();

		public void Init()
		{
			foreach (var _ in utdata.Split('\n').Select((line, lineNumber) => new { line = line.Length == 0 || line[0] == '@' || line[0] == '#' ? String.Empty : line.Split('#')[0], lineNumber = lineNumber + 1 }))
			{
				if (_.line == String.Empty) continue;

				// Columns (c1, c2,...) are separated by semicolons
				// They have the following meaning: source; NFC; NFD; NFKC; NFKD
				var _parts = _.line.Split(';');

				Assert.IsTrue(_parts.Length == 6, "There should be five columns, not {0} -- line {1}", _parts.Length - 1, _.lineNumber);
				Array.Resize(ref _parts, 5);

				// split p
				var parts = _parts.Select(p =>
					{
						return p.Split(' ').Select(x =>
							{
								return Convert.ToInt32(x, 16);
							}).ToList();
					}).ToList();

				lineInfo.Add(parts, _.lineNumber + ": " + _.line);

				tests.Add(parts);
			}
		}

		void DoTest(List<List<int>> test)
		{
			var raw = test.Select(p =>
				{
					return String.Join("", p.Select(x => char.ConvertFromUtf32(x)));
				}).ToList();

			var nfd	= raw.Select(s => UNorm.Normalize(s, UNorm.NormalizationForm.FormD))	.ToList();
			var nfkd	= raw.Select(s => UNorm.Normalize(s, UNorm.NormalizationForm.FormKD))	.ToList();
			var nfc	= raw.Select(s => UNorm.Normalize(s, UNorm.NormalizationForm.FormC))	.ToList();
			var nfkc	= raw.Select(s => UNorm.Normalize(s, UNorm.NormalizationForm.FormKC))	.ToList();

			//NFC
			Assert.AreEqual(nfc[0], raw[1], lineInfo.GetValue(test, (_) => null) + ": c2 != NFC(c1)");
			Assert.AreEqual(nfc[1], raw[1], lineInfo.GetValue(test, (_) => null) + ": c2 != NFC(c2)");
			Assert.AreEqual(nfc[2], raw[1], lineInfo.GetValue(test, (_) => null) + ": c2 != NFC(c3)");
			Assert.AreEqual(nfc[3], raw[3], lineInfo.GetValue(test, (_) => null) + ": c4 != NFC(c4)");
			Assert.AreEqual(nfc[4], raw[3], lineInfo.GetValue(test, (_) => null) + ": c4 != NFC(c5)");
			//NFD
			Assert.AreEqual(nfd[0], raw[2], lineInfo.GetValue(test, (_) => null) + ": c3 != NFD(c1)");
			Assert.AreEqual(nfd[1], raw[2], lineInfo.GetValue(test, (_) => null) + ": c3 != NFD(c2)");
			Assert.AreEqual(nfd[2], raw[2], lineInfo.GetValue(test, (_) => null) + ": c3 != NFD(c3)");
			Assert.AreEqual(nfd[3], raw[4], lineInfo.GetValue(test, (_) => null) + ": c5 != NFD(c4)");
			Assert.AreEqual(nfd[4], raw[4], lineInfo.GetValue(test, (_) => null) + ": c5 != NFD(c5)");
			//NFKC
			Assert.AreEqual(nfkc[0], raw[3], lineInfo.GetValue(test, (_) => null) + ": c5 != NFKC(c1)");
			Assert.AreEqual(nfkc[1], raw[3], lineInfo.GetValue(test, (_) => null) + ": c5 != NFKC(c2)");
			Assert.AreEqual(nfkc[2], raw[3], lineInfo.GetValue(test, (_) => null) + ": c5 != NFKC(c3)");
			Assert.AreEqual(nfkc[3], raw[3], lineInfo.GetValue(test, (_) => null) + ": c5 != NFKC(c4)");
			Assert.AreEqual(nfkc[4], raw[3], lineInfo.GetValue(test, (_) => null) + ": c5 != NFKC(c5)");
			//NFKD
			Assert.AreEqual(nfkd[0], raw[4], lineInfo.GetValue(test, (_) => null) + ": c5 != NFKD(c1)");
			Assert.AreEqual(nfkd[1], raw[4], lineInfo.GetValue(test, (_) => null) + ": c5 != NFKD(c2)");
			Assert.AreEqual(nfkd[2], raw[4], lineInfo.GetValue(test, (_) => null) + ": c5 != NFKD(c3)");
			Assert.AreEqual(nfkd[3], raw[4], lineInfo.GetValue(test, (_) => null) + ": c5 != NFKD(c4)");
			Assert.AreEqual(nfkd[4], raw[4], lineInfo.GetValue(test, (_) => null) + ": c5 != NFKD(c5)");
		}

		[TestMethod]
		public void NormalizationTests()
		{
			Init();

			foreach (var test in tests)
			{
				DoTest(test);
			}
		}

		[TestMethod]
		[ExpectedException(typeof(AssertFailedException))]
		public void ShouldFail()
		{
			Init();

			// deep-copy test
			var test = tests[0];
			test[0][0] += 1;
			DoTest(test);
		}
	}
}
