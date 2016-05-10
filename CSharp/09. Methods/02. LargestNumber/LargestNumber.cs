using System;

namespace _02.LargestNumber
{
    /// <summary>
    /// Write a method GetMax() with two parameters that returns the larger of two integers.
    /// Write a program that reads 3 integers from the console and prints the largest of 
    /// them using the method GetMax().
    /// </summary>
    class LargestNumber
    {
        static void Main()
        {
            int biggestNumber;
            string[] numbers = Console.ReadLine().Split();
       

            biggestNumber = GetMax(int.Parse(numbers[0]), int.Parse(numbers[1]));
            biggestNumber = GetMax(biggestNumber, int.Parse(numbers[2]));

            Console.WriteLine(biggestNumber);
        }

        static int GetMax(int first, int second)
        {
            if(first > second)
            {
                return first;
            }

            return second;
        }
    }
}
