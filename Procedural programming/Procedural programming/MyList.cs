using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProceduralProgramming
{
	public class MyList<T> : IEnumerable<T>
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
