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
			filmsList = filmsList.ReadToFile(args[0]);
			filmsList.WriteToFile<Games>(args[1], false);
			System.Diagnostics.Process process = new System.Diagnostics.Process();
			process.StartInfo.FileName = args[1];
			process.Start();
		}
	}
}
