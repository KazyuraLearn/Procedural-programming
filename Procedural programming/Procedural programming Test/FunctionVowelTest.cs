using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProceduralProgramming;

namespace ProceduralProgrammingTest
{
	[TestClass]
	public class FunctionVowelTest
	{
		[TestMethod]
		public void EmptyString()
		{
			string arg = "";
			int expected = 0;

			Films film = new Films(arg, arg, new Object());
			int actual = film.VowelCount;

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void NotVowel()
		{
			string arg = "bcDF БВДж \n lkr";
			int expected = 0;

			Films film = new Films(arg, arg, new Object());
			int actual = film.VowelCount;

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void SixVowel()
		{
			string arg = "bcDFое БВДиж \n eailkr";
			int expected = 6;

			Films film = new Films(arg, arg, new Object());
			int actual = film.VowelCount;

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void ThirtyTwoVowel()
		{
			string arg = "AЕЁИОУЫЭЮЯаеёиоуыэюяAEIOUYaeiouy";
			int expected = 32;

			Films film = new Films(arg, arg, new Object());
			int actual = film.VowelCount;

			Assert.AreEqual(expected, actual);
		}
	}
}
