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
		enum Type { рисованный, кукольный, пластилиновый };
		Type ob;

		public Cartoon(string name, int type)
		{
			this.name = name;
			if (type == 0) ob = Type.кукольный;
			else if (type == 1) ob = Type.пластилиновый;
			else ob = Type.рисованный;
		}

		public override string ToString()
		{
			return "Название мультфильма: " + name + ". Тип: " + ob;
		}
	}
}
