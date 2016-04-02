using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.SumOfFiveNumbers
{
    /// <summary>
    /// Write a program that reads 5 integer numbers 
    /// from the console and prints their sum.
    /// </summary>
    class SumOfFiveNumbers
    {
        static void Main(string[] args)
        {
            int iterationsCount = 5;

            List<int> inputList = new List<int>();
            for (int i = 1; i <= iterationsCount; i++)
            {
                int number = int.Parse(Console.ReadLine());
                inputList.Add(number);
            }

            int maxInput = inputList.Max();

            Console.WriteLine("{0}", maxInput);
        }
    }
}
