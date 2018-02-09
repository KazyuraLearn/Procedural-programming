using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProceduralProgramming
{
	public struct Cartoon
	{
		enum Type { рисованный, кукольный, пластилиновый };
		Type ob;

		public Cartoon(int type)
		{
			if (type == 0) ob = Type.кукольный;
			else if (type == 1) ob = Type.пластилиновый;
			else ob = Type.рисованный;
		}

		public override string ToString()
		{
			return ". Тип: " + ob;
		}
	}
}
