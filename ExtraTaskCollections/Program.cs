using System;

namespace ExtraTaskCollections
{
	internal class Program
	{
		static void Main(string[] args)
		{
			
			var myInt = new MyInt();

			int[] ints = { 2, 4, 6, 8, 10 };

			myInt.AddRange(ints);

			myInt.GetEnumerator();

			Console.WriteLine(myInt.Current);


			//int sum = 0;
			foreach (int number in myInt)
			{
				//sum += number;
				Console.WriteLine(myInt.Current);
			}
			

			Console.ReadLine();
		}
	}
}
