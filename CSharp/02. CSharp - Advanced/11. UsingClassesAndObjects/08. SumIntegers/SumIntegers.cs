using System;

namespace _08.SumIntegers
{
    /// <summary>
    /// You are given a sequence of positive integer values written into
    /// a string, separated by spaces. Write a function that reads these
    /// values from given string and calculates their sum. 
    /// </summary>
    class SumIntegers
    {
        static void Main(string[] args)
        {
            string[] inputNumbers = Console.ReadLine().Split(' ');

            double sum = CalculateSetSum(inputNumbers);
            Console.WriteLine("{0:F0}", sum);
        }

        private static double CalculateSetSum(string[] inputNumbers)
        {
            double sum = 0;
            for (int i = 0; i < inputNumbers.Length; i++)
            {
                sum += double.Parse(inputNumbers[i]);
            }

            return sum;
        }
    }
}
