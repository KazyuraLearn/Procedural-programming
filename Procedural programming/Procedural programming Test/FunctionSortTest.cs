using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProceduralProgramming;

namespace ProceduralProgrammingTest
{
	[TestClass]
	public class FunctionSortTest
	{
		[TestMethod]
		public void EmptyList()
		{
			MyList<Films> filmsList = new MyList<Films>();
			MyList<Films> expected = new MyList<Films>();

			filmsList.Sort();

			Assert.AreEqual(expected, filmsList);
		}

		[TestMethod]
		public void NotEmptyList()
		{
			MyList<Films> filmsList = new MyList<Films>()
			{ 
				new Films("Aaaa", "", new Object()),
				new Films("Daaa", "", new Object()),
				new Films("Ddaa", "", new Object()),
				new Films("Ddda", "", new Object()),
				new Films("Dddd", "", new Object()),
			};
			MyList<Films> expected = new MyList<Films>()
			{				
				new Films("Dddd", "", new Object()),
				new Films("Ddda", "", new Object()),
				new Films("Ddaa", "", new Object()),
				new Films("Daaa", "", new Object()),
				new Films("Aaaa", "", new Object()),
			};

			filmsList.Sort();

			Assert.AreEqual(expected, filmsList);
		}

		[TestMethod]
		public void OnlyVowelList()
		{
			MyList<Films> filmsList = new MyList<Films>()
			{ 
				new Films("Ауи", "", new Object()),
				new Films("Ieи", "", new Object()),
				new Films("уЕY", "", new Object()),
				new Films("ЯюЭ", "", new Object()),
				new Films("UоЮ", "", new Object()),
			};
			MyList<Films> expected = new MyList<Films>()
			{				
				new Films("Ауи", "", new Object()),
				new Films("Ieи", "", new Object()),
				new Films("уЕY", "", new Object()),
				new Films("ЯюЭ", "", new Object()),
				new Films("UоЮ", "", new Object()),
			};

			filmsList.Sort();

			Assert.AreEqual(expected, filmsList);
		}
	}
}
