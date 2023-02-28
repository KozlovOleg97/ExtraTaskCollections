using ExtraTaskCollections;
using System;
using System.Drawing;
using Xunit;

namespace TestProjectCollection
{
	public class TestCollection
	{
		// 2 6 10 14 18 22 27

		[Fact]
		public void MyCollection_FirstElement_IsTwo()
		{
			// Arrange
			var seq = new MyInt();



			int[] ints = { 2, 4, 6, 8, 10, 12, 15 };

			seq.AddRange(ints);

			// Act 

			var x = seq.GetEnumerator();
			x.MoveNext();
			x.MoveNext();
			var result = x.Current;

			// Assert
			Assert.Equal(10, result);
		}
	}
}
