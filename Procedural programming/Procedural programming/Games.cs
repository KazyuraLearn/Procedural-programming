using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProceduralProgramming
{
	public struct Games
	{
		string director;

		public Games(string director)
		{
			this.director = director;
		}

		public override string ToString()
		{
			return ". Режисёр: " + director;
		}
	}
}
