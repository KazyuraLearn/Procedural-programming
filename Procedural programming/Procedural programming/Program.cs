﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProceduralProgramming
{
	class Program
	{
		static void Main(string[] args)
		{
			MyList<Films> filmsList = new MyList<Films>();
			ReadToFile(args[0], filmsList);
			WriteToFile(args[1], filmsList);
			System.Diagnostics.Process process = new System.Diagnostics.Process();
			process.StartInfo.FileName = args[1];
			process.Start();
		}

		static void ReadToFile(string fileName, MyList<Films> filmsList)
		{
			FileStream file = new FileStream(fileName, FileMode.Open);
			StreamReader reader = new StreamReader(file, Encoding.GetEncoding(1251));
			while (reader.Peek() > -1)
			{
				string[] buf = reader.ReadLine().Split(new char[] { '#' });
				if (buf[0] == "1")
					filmsList.Add(new Films(new Games(buf[1], buf[2], buf[3])));
				else if (buf[0] == "2")
					filmsList.Add(new Films(new Cartoon(buf[1], buf[2], Convert.ToInt32(buf[3]))));
				else
					filmsList.Add(new Films(new Documentary(buf[1], buf[2], Convert.ToInt32(buf[3]))));
			}
			reader.Close(); file.Close();
		}

		static void WriteToFile(string fileName, MyList<Films> filmsList)
		{
			FileStream file = new FileStream(fileName, FileMode.OpenOrCreate);
			StreamWriter writer = new StreamWriter(file);
			Sort(filmsList);
			writer.WriteLine("Список фильмов содержит: " + filmsList.Count + " элементов");
			writer.WriteLine("----------------------------------------------------------");
			foreach (var el in filmsList)
				writer.WriteLine(el.ob.ToString());
			writer.Close(); file.Close();
		}

		static void WriteToFileGames(string fileName, MyList<Films> filmsList)
		{
			FileStream file = new FileStream(fileName, FileMode.OpenOrCreate);
			StreamWriter writer = new StreamWriter(file);
			Sort(filmsList);
			writer.WriteLine("Список фильмов содержит: " + filmsList.Count + " элементов");
			writer.WriteLine("----------------------------------------------------------");
			foreach (var el in filmsList)
				if (el.ob is Games)
					writer.WriteLine(el.ob.ToString());
			writer.Close(); file.Close();
		}

		static void Sort(MyList<Films> filmsList)
		{
			bool flag = true;
			while (flag)
			{
				flag = false;
				Node<Films> current = filmsList.Head;
				while (current.next != null)
				{
					if (Films.Compare(current.data, current.next.data) == 1)
					{
						filmsList.Swap(current, current.next);
						flag = true;
					}
					current = current.next;
				}
			}
		}
	}
}
