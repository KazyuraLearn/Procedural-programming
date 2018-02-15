using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProceduralProgramming
{
	public interface IReturnTypeObj
	{
		Type ObjType();
	}

	public struct Films : IComparable<Films>, IReturnTypeObj
	{
		string name;
		string country;
		public Object ob;

		public Films(string name, string country, Object ob)
		{
			this.name = name;
			this.country = country;
			this.ob = ob;
		}

		public int VowelCount
		{
			get
			{
				int result = 0;
				string vowel = "АЕЁИОУЫЭЮЯаеёиоуыэюяAEIOUYaeiouy";
				foreach (var el in name)
					if (vowel.IndexOf(el) != -1)
						result++;
				return result;
			}
		}

		public int CompareTo(Films ob)
		{
			if (this.VowelCount == ob.VowelCount)
				return 0;
			return (this.VowelCount > ob.VowelCount) ? 1 : -1;
		}

		public override string ToString()
		{
			return "Название фильма: " + name + ". Страна: " + country + ". Жанр: " + ob.GetType().Name + ob.ToString();
		}

		public Type ObjType()
		{
			return ob.GetType();
		}
	}
}
