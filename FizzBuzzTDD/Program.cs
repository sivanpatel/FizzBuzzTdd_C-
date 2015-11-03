using System;
using System.Linq;
using System.Collections.Generic;

namespace FizzBuzz
{
	 class FizzBuzzMain
	{
		public List<string> GetFizzBuzz(int ceiling)
		{
			var sequence = new List<string>();

			for (var i = 1; i <= ceiling; i++)
			{
				sequence.Add(GetNextFizzBuzz(i));
			}
			return sequence;
		}

		public string GetNextFizzBuzz(int position)
		{
			var nextFizzBuzz = string.Empty;
			var isFizzOrBuzz = false;

			if (position % 3 == 0)
			{
				nextFizzBuzz = "Fizz";
				isFizzOrBuzz = true;
			}
			else if (position % 5 == 0)
			{
				nextFizzBuzz = "Buzz";
				isFizzOrBuzz = true;
			}
			else
			{
				nextFizzBuzz = position.ToString();
			}

			if (isFizzOrBuzz && position % 3 == 0 && position % 5 == 0)
			{
				nextFizzBuzz = "FizzBuzz";
			}

			return nextFizzBuzz;
		}

	}
}
