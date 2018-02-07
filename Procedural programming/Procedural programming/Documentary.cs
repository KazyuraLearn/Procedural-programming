using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProceduralProgramming
{
	struct Documentary
	{
		string name;
		int yearRelease;

		public Documentary(string name, int yearRelease)
		{
			this.name = name;
			this.yearRelease = yearRelease;
		}

		public override string ToString()
		{
			return "Название документального фильма: " + name + ". Год выпуска: " + yearRelease;
		}
	}
}
