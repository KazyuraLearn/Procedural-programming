using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProceduralProgramming;

namespace ProceduralProgrammingTest
{
	[TestClass]
	public class FunctionReadToFileTest
	{
		[TestMethod]
		public void EmptyFile()
		{
			MyList<Films> filmsList = new MyList<Films>();
			MyList<Films> expected = new MyList<Films>();

			filmsList = filmsList.ReadToFile("EmptyFile.txt");

			Assert.AreEqual(expected, filmsList);
		}

		[TestMethod]
		public void ImaginaryFile()
		{
			MyList<Films> filmsList = new MyList<Films>();
			MyList<Films> expected = new MyList<Films>();

			filmsList = filmsList.ReadToFile("H:\\File.txt");

			Assert.AreEqual(expected, filmsList);
		}

		[TestMethod]
		public void IncorrectFile()
		{
			MyList<Films> filmsList = new MyList<Films>();
			MyList<Films> expected = new MyList<Films>()
			{
				new Films("Рапунцель", "Англия", new Cartoon(2)),
				new Films("Неудержимые", "США", new Games("Сильвестр Сталоне"))
			};

			filmsList = filmsList.ReadToFile("IncorrectFile.txt");

			Assert.AreEqual(expected, filmsList);
		}

		[TestMethod]
		public void CorrectFile()
		{
			MyList<Films> filmsList = new MyList<Films>();
			MyList<Films> expected = new MyList<Films>()
			{
				new Films("Побег из курятника", "Франция", new Cartoon(2)),
				new Films("Мстители", "Германия", new Games("Джосс Уидон")),
				new Films("Сквозь вселенную", "Канада", new Documentary(1997))
			};

			filmsList = filmsList.ReadToFile("CorrectFile.txt");

			Assert.AreEqual(expected, filmsList);
		}

		[TestMethod]
		public void CorrectFileOneNode()
		{
			MyList<Films> filmsList = new MyList<Films>();
			MyList<Films> expected = new MyList<Films>()
			{
				new Films("Побег из курятника", "Франция", new Cartoon(2)),
			};

			filmsList = filmsList.ReadToFile("CorrectFileOneNode.txt");

			Assert.AreEqual(expected, filmsList);
		}
	}
}
