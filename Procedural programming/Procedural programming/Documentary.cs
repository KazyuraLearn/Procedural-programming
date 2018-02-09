using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProceduralProgramming
{
	public struct Documentary
	{
		int yearRelease;

		public Documentary(int yearRelease)
		{
			this.yearRelease = yearRelease;
		}

		public override string ToString()
		{
			return ". Год выпуска: " + yearRelease;
		}
	}
}
