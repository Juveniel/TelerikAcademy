using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.PrintSmallestAndBiggestNumber
{
    /// <summary>
    /// Write a program that reads from the console a series of integers
    /// and prints the smallest and largest of them.
    /// </summary>

    class PrintSmallestAndBiggestNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many numbers would you like to enter ?");
            int n = int.Parse(Console.ReadLine());

            List<int> numbersList = new List<int>();
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter the value for number №{0}", i + 1);
                numbersList.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine("The smallest number is: {0}", numbersList.Min());
            Console.WriteLine("The largest number is: {0}", numbersList.Max());
        }
    }
}
