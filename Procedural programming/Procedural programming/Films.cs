using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProceduralProgramming
{
	struct Films
	{
		public Object ob;

		public Films(Object ob)
		{
			this.ob = ob;
		}

		public int VowelCount
		{
			get
			{
				int result = 0;
				string vowel = "AЕЁИОУЫЭЮЯаеёиоуыэюяAEIOUYaeiouy";
				if (ob is Cartoon)
				{
					Cartoon temp = (Cartoon)ob;
					foreach (var el in temp.name)
						if (vowel.IndexOf(el) != -1)
							result++;
				}
				else
				{
					Games temp = (Games)ob;
					foreach (var el in temp.name)
						if (vowel.IndexOf(el) != -1)
							result++;
				}
				return result;
			}
		}
	}
}
