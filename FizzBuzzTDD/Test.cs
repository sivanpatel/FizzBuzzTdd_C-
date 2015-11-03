using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace FizzBuzz
{
	[TestFixture]
	public class Test
	{
		[Test]
	public void TestFizzBuzz_ShouldReturnTwoIntegers()
		{
			// Arrange
			FizzBuzzMain fizbuzz = new FizzBuzzMain ();
			var expected = new List<string>{ "1", "2" };

			// Act
			var actual = fizbuzz.GetFizzBuzz (2);

			// Assert
			CollectionAssert.AreEqual (expected, actual);
		}
		[Test]
		public void TestFizzBuzz_ShouldReturnFirstThreeItems()
		{
			FizzBuzzMain fizbuzz = new FizzBuzzMain ();
			var expected = new List<string>{ "1", "2", "Fizz" };
			var actual = fizbuzz.GetFizzBuzz (3);
			CollectionAssert.AreEqual (expected, actual);
		}
		[Test]
		public void TestFizzBuzz_ShouldReturnFirstFiveItems()
		{
			FizzBuzzMain fizbuzz = new FizzBuzzMain ();
			var expected = new List<string>{ "1", "2", "Fizz", "4", "Buzz" };
			var actual = fizbuzz.GetFizzBuzz (5);
			CollectionAssert.AreEqual (expected, actual);
		}
		[Test]
		public void TestFizzBuzz_ShouldReturnFizzBuzz()
		{
			FizzBuzzMain fizbuzz = new FizzBuzzMain ();
			var position = 15;
			var expected = "FizzBuzz";

			var actualFizzBuzzList = fizbuzz.GetFizzBuzz(position);
			var actual = actualFizzBuzzList.ElementAt(position - 1);

			Assert.AreEqual(expected, actual);
		}
	}
}

