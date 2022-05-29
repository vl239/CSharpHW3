// C# Assignment 3: Object-oriented programming
// WORKING WITH METHODS: Problem 2

// Fibonacci sequence

using System;
namespace WorkingWithMethods
{
	public class ProblemTwo
	{
		public static int Fibonacci(int index)
        {
			// base case
			if (index == 1 || index == 2)
            {
				return 1;
            }

			return Fibonacci(index - 1) + Fibonacci(index - 2);
        }
	}
}

