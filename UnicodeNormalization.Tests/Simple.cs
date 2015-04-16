using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnicodeNormalization.Tests
{
	[TestClass]
	public class Simple
	{
		[TestMethod]
		public void SimpleExamples()
		{
			var str = "äiti";
			Assert.AreEqual("\u00e4\u0069\u0074\u0069", UNorm.Normalize(str, UNorm.NormalizationForm.FormC));
			Assert.AreEqual("\u0061\u0308\u0069\u0074\u0069", UNorm.Normalize(str, UNorm.NormalizationForm.FormD));
			Assert.AreEqual("\u00e4\u0069\u0074\u0069", UNorm.Normalize(str, UNorm.NormalizationForm.FormKC));
			Assert.AreEqual("\u0061\u0308\u0069\u0074\u0069", UNorm.Normalize(str, UNorm.NormalizationForm.FormKD));
		}
	}
}
