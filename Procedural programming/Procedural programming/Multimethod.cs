using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProceduralProgramming
{
	class Multimethod
	{
		static string Information(Cartoon x, Cartoon y)
		{
			return x.GetType().Name + "\n" + y.GetType().Name;
		}

		static string Information(Games x, Games y)
		{
			return x.GetType().Name + "\n" + y.GetType().Name;
		}

		static string Information(Documentary x, Documentary y)
		{
			return x.GetType().Name + "\n" + y.GetType().Name;
		}

		static string Information(Cartoon x, Games y)
		{
			return x.GetType().Name + "\n" + y.GetType().Name;
		}

		static string Information(Cartoon x, Documentary y)
		{
			return x.GetType().Name + "\n" + y.GetType().Name;
		}

		static string Information(Games x, Cartoon y)
		{
			return x.GetType().Name + "\n" + y.GetType().Name;
		}

		static string Information(Games x, Documentary y)
		{
			return x.GetType().Name + "\n" + y.GetType().Name;
		}

		static string Information(Documentary x, Cartoon y)
		{
			return x.GetType().Name + "\n" + y.GetType().Name;
		}

		static string Information(Documentary x, Games y)
		{
			return x.GetType().Name + "\n" + y.GetType().Name;
		}

		static string InformationMain(Films x, Films y)
		{
			dynamic One = x.ob, Two = y.ob;
			return Information(One, Two);
		}

		public static int MultiWriteToFile(string fileName, MyList<Films> filmsList)
		{
			try
			{
				if (File.Exists(fileName))
					File.Delete(fileName);
				using (FileStream file = File.Create(fileName))
				{
					using (StreamWriter writer = new StreamWriter(file))
					{
						Node<Films> currentOne = filmsList.Head;
						while (currentOne != null)
						{
							Node<Films> currentTwo = currentOne.next;
							while (currentTwo != null)
							{
								writer.WriteLine(InformationMain(currentOne.data, currentTwo.data) + "\n");
								currentTwo = currentTwo.next;
							}
							currentOne = currentOne.next;
						}
					}
				}
				return 0;
			}
			catch
			{
				return -1;
			}
		}
	}
}
