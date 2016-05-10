using System;

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
            int[] numbers = new int[5];
            var userInput = Console.ReadLine().Split(' ');

            for(int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(userInput[i]);
            }

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

        private static double AverageOfSet(params int[] numArray)
        {
            double sum = 0;
            double average = 0;
            for (int i = 0; i < numArray.Length; i++)
            {
                sum = sum + double.Parse(numArray[i].ToString());
            }

            average = sum / numArray.Length;

            return average;
        }

        private static int SumOfSet(params int[] numArray)
        {
            int sum = 0;
            for (int i = 0; i < numArray.Length; i++)
            {
                sum = sum + numArray[i];
            }

            return sum;
        }

        private static int ProductOfSet(params int[] numArray)
        {
            int product = 0;
            for (int i = 0; i < numArray.Length; i++)
            {
                product = product * numArray[i];
            }

            return product;
        }

    }
}
