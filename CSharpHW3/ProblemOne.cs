// C# Assignment 3: Object-oriented programming
// WORKING WITH METHODS: Problem 1

// Take an array and reverse the contents

using System;
namespace WorkingWithMethods
{
	public class ProblemOne
	{
		public static int[] GenerateNumbers(int length)
        {
			Random random = new Random();
			int[] array = new int[length];

            for (int i = 0; i < length; i++)
			{
				array[i] = random.Next(100);
            }

			return array;
        }

		public static void Reverse(int[] array)
        {
			for (int i = 0; i < array.Length / 2; i++)
            {
				int temp = array[i];
				array[i] = array[array.Length - i - 1];
				array[array.Length - i - 1] = temp;
            }
        }

		public static void PrintNumbers(int[] array)
        {
			for (int i = 0; i < array.Length; i++)
			{
                Console.WriteLine(array[i]);
            }
        }
	}
}

