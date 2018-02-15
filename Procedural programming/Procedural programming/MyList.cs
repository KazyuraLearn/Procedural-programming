using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProceduralProgramming
{
	public class MyList<T> : IEnumerable<T> where T : IComparable<T>, IReturnTypeObj
	{
		Node<T> head;
		Node<T> tail;
		int count;

		public Node<T> Head { get { return head; } }
		public int Count { get { return count; } }
		
		public void Add(T data)
		{
			Node<T> node = new Node<T>(data);
			if (head == null)
				head = node;
			else
				tail.next = node;
			tail = node;

			count++;
		}

		public bool Remove(T data)
		{
			Node<T> current = head;
			Node<T> previous = null;

			while (current != null)
			{
				if (current.data.Equals(data))
				{
					if (previous != null)
					{
						previous.next = current.next;
						if (current.next == null)
							tail = previous;
					}
					else
					{
						head = head.next;
						if (head == null)
							tail = null;
					}
					count--;
					return true;
				}

				previous = current;
				current = current.next;
			}
			return false;
		}

		public void Swap(Node<T> one, Node<T> two)
		{
			T temp = one.data;
			one.data = two.data;
			two.data = temp;
		}

		public void Sort()
		{
			if (Count == 0)
				return;
			bool flag = true;
			while (flag)
			{
				flag = false;
				Node<T> current = head;
				while (current.next != null)
				{
					if (current.data.CompareTo(current.next.data) == 1)
					{
						Swap(current, current.next);
						flag = true;
					}
					current = current.next;
				}
			}
		}

		public string ReadToFile(string fileName, MyList<Films> filmsList)
		{
			if (fileName == "" || fileName == null)
				return "Файл не задан";
			if (!File.Exists(fileName))
				return "Файл не найден";
			try
			{
				using (StreamReader reader = new StreamReader(fileName, Encoding.GetEncoding(1251)))
				{
					while (reader.Peek() > -1)
					{
						string[] buf = reader.ReadLine().Split(new char[] { '#' });
						if (buf.Length != 4)
							continue;
						if (buf[0] == "1")
							filmsList.Add(new Films(buf[1], buf[2], new Games(buf[3])));
						else if (buf[0] == "2")
							filmsList.Add(new Films(buf[1], buf[2], new Cartoon(Convert.ToInt32(buf[3]))));
						else if (buf[0] == "3")
							filmsList.Add(new Films(buf[1], buf[2], new Documentary(Convert.ToInt32(buf[3]))));
					}
				}
				return null;
			}
			catch (FormatException)
			{
				return "Входные данные некорректны. Строка там, где ожидалось число.";
			}
			catch (OverflowException)
			{
				return "Входные данные некорректны. Число слишком большое или слишком маленькое.";
			}
			catch (IOException)
			{
				return "Не удаётся получить доступ к файлу. Вероятно он занят другим приложением.";
			}
		}

		public int WriteToFile<type>(string fileName, bool baseStruct)
		{
			try
			{
				if (File.Exists(fileName))
					File.Delete(fileName);
				using (FileStream file = File.Create(fileName))
				{
					using (StreamWriter writer = new StreamWriter(file))
					{
						Node<T> current = head;
						while (current != null)
						{
							if (current.data.ObjType().Equals(typeof(type)) && !baseStruct)
								writer.WriteLine(current.data.ToString());
							if (current.data.GetType().Equals(typeof(type)) && baseStruct)
								writer.WriteLine(current.data.ToString());
							current = current.next;
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

		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable)this).GetEnumerator();
		}

		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			Node<T> current = head;
			while (current != null)
			{
				yield return current.data;
				current = current.next;
			}
		}
	}
}
