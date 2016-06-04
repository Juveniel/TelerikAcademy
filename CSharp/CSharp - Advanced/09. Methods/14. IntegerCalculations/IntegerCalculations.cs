using System;
using System.Linq;

namespace _14.IntegerCalculations
{
    /// <summary>
    /// Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
    /// Use variable number of arguments. Write a program that reads 5 elements and prints their minimum,
    /// maximum, average, sum and product.
    /// </summary>
    class IntegerCalculations
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.WriteLine(MinOfSet(numbers));
            Console.WriteLine(MaxOfSet(numbers));
            Console.WriteLine("{0:F2}", AverageOfSet(numbers));
            Console.WriteLine(SumOfSet(numbers));
            Console.WriteLine(ProductOfSet(numbers));
        }

        private static int MinOfSet(params int[] numArray)
        {
            int min = numArray[0];
            for (int i = 0; i < numArray.Length; i++)
            {
                if (numArray[i] < min)
                {
                    min = numArray[i];
                }
            }

            return min;
        }

        private static int MaxOfSet(params int[] numArray)
        {
            int max = numArray[0];
            for (int i = 0; i < numArray.Length; i++)
            {
                if (numArray[i] > max)
                {
                    max = numArray[i];
                }
            }

            return max;
        }

        private static decimal AverageOfSet(params int[] numArray)
        {
            decimal sum = 0;
            decimal average = 0;
            for (int i = 0; i < numArray.Length; i++)
            {
                sum = sum + decimal.Parse(numArray[i].ToString());
            }

            average = sum / numArray.Length;

            return average;
        }

        private static long SumOfSet(params int[] numArray)
        {
            long sum = 0;
            for (int i = 0; i < numArray.Length; i++)
            {
                sum = sum + numArray[i];
            }

            return sum;
        }

        private static long ProductOfSet(params int[] numArray)
        {
            long product = 1;
            for (int i = 0; i < numArray.Length; i++)
            {
                product = product * numArray[i];
            }

            return product;
        }

    }
}
