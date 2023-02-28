using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExtraTaskCollections
{
	internal class MyInt : IEnumerable, IEnumerator
	{

		private List<int> list_Array = new List<int>();

		int index = -1;

		public void Add(int i)
		{
			list_Array.Add(i);
		}
		public void AddRange(int[] aari)
		{
			list_Array.AddRange(aari);
		}

		public IEnumerator GetEnumerator()
		{
			return this;
		}

		public bool MoveNext()
		{
			if (index < list_Array.Count - 2)
			{
				index++;
				return true;
				
			}
			return false;
		}

		public void Reset()
		{
			index = -1;
		}

		public object Current=> index < 0 ? list_Array[index + 1] 
			: list_Array[index] + list_Array[index + 1];
	}
}