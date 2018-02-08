using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProceduralProgramming
{
	struct Cartoon
	{
		string name;
		string country;
		enum Type { рисованный, кукольный, пластилиновый };
		Type ob;

		public Cartoon(string name, string country, int type)
		{
			this.name = name;
			this.country = country;
			if (type == 0) ob = Type.кукольный;
			else if (type == 1) ob = Type.пластилиновый;
			else ob = Type.рисованный;
		}

		public override string ToString()
		{
			return "Название мультфильма: " + name + ". Страна: " + country + ". Тип: " + ob;
		}
	}
}
