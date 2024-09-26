using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denemelist
{
	public class MyList<T>
	{
		// dizimiz olucak 
		private T[] _items;
		private int _count;

		public MyList()
		{
			T[] _items = new T[2];
			_count = 0;
		}

		public void Add(T item)
		{
			if (_items.Length == _count)
			{
				RENEW();
			}

			_items[_count] = item;

			_count++;
		}

		public void RENEW()
		{
			T[] newarray = new T[_count * 2];

			Array.Copy(_items, newarray, _items.Length);
			_items = newarray;

		}

		public void REMOVE(T item)
		{
			T[] newarrayfortemp = new T[_count];
			int tempindex = 0;

			for (int i = 0; i < _items.Length; i++)
			{
				if (!EqualityComparer<T>.Default.Equals(item, _items[i]))
				{
					newarrayfortemp[tempindex] = _items[i];
				}

				tempindex++;
			}



			_items = newarrayfortemp;

		}

		public int Count {
			get {return  _count ; } 
		}

		public T[] GetItems()
		{
			T[] lastresults = new T[_count];
			Array.Copy(_items, lastresults, _items.Length);

			return lastresults;
		}


		public T Get(int index) 
		{	if (index>_count || index<0 )
			{
				throw new IndexOutOfRangeException();
			}
			
			T myindexitem = _items[index];
			return myindexitem;
		}

	}
}
