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

            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            biggestNumber = GetMax(firstNumber, secondNumber);
            biggestNumber = GetMax(biggestNumber, thirdNumber);

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
