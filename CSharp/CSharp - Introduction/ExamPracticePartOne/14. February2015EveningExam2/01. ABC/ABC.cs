using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.ABC
{
    class ABC
    {
        static void Main(string[] args)
        {
            List<decimal> numbersList = new List<decimal>();

            numbersList.Add(decimal.Parse(Console.ReadLine()));
            numbersList.Add(decimal.Parse(Console.ReadLine()));
            numbersList.Add(decimal.Parse(Console.ReadLine()));


            Console.WriteLine(numbersList.Max());
            Console.WriteLine(numbersList.Min());
            Console.WriteLine("{0:F3}", numbersList.Average());
        }
    }
}
