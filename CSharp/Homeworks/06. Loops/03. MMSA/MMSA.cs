using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MMSA
{
    /// <summary>
    /// Write a program that reads from the console a sequence of N integer 
    /// numbers and returns the minimal, the maximal number, the sum and the 
    /// average of all numbers (displayed with 2 digits after the decimal point).
    /// </summary>
    class MMSA
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<double> numbersList = new List<double>();
            for(int i = 0; i < n; i++)
            {
                numbersList.Add(double.Parse(Console.ReadLine()));
            }

            Console.WriteLine("min={0}", numbersList.Min());
            Console.WriteLine("max={0}", numbersList.Max());
            Console.WriteLine("sum={0:F2}", numbersList.Sum());
            Console.WriteLine("avg={0:F2}", numbersList.Average());
        }
    }
}
