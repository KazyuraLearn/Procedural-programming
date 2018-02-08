using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProceduralProgramming
{
	struct Documentary
	{
		public string name;
		string country;
		int yearRelease;

		public Documentary(string name, string country, int yearRelease)
		{
			this.name = name;
			this.country = country;
			this.yearRelease = yearRelease;
		}

		public override string ToString()
		{
			return "Название документального фильма: " + name + ". Страна: " + country + ". Год выпуска: " + yearRelease;
		}
	}
}
