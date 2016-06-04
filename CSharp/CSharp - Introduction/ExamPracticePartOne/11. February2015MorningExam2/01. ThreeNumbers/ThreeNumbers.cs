using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.ThreeNumbers
{
    class ThreeNumbers
    {
        static void Main(string[] args)
        {
            List<int> numbersList = new List<int>();
            numbersList.Add(int.Parse(Console.ReadLine()));
            numbersList.Add(int.Parse(Console.ReadLine()));
            numbersList.Add(int.Parse(Console.ReadLine()));

            Console.WriteLine(numbersList.Max());
            Console.WriteLine(numbersList.Min());
            Console.WriteLine("{0:F2}", numbersList.Average());
        }
    }
}
