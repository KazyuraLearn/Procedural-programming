using System;
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
			Console.WriteLine(filmsList.ReadToFile(args[0], filmsList));
			filmsList.WriteToFile<Games>(args[1], false);

			if (File.Exists(args[1]))
			{
				System.Diagnostics.Process process = new System.Diagnostics.Process();
				process.StartInfo.FileName = args[1];
				process.Start();
			}
			Console.ReadKey();
		}
	}
}
