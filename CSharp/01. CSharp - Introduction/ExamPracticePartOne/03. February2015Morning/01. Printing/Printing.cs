using System;
using System.Collections.Generic;

namespace _01.Printing
{
    /// <summary>
    /// February 2015 Morning 01. Printing
    /// </summary>
    class Printing
    {
        static void Main(string[] args)
        {
            decimal numberOfStudents = decimal.Parse(Console.ReadLine());
            decimal numberOfPapers = decimal.Parse(Console.ReadLine());
            decimal realmPrice = decimal.Parse(Console.ReadLine());

            CalcTotalAmount(numberOfStudents, numberOfPapers, realmPrice);
        }

        static void CalcTotalAmount(decimal students, decimal papers, decimal price)
        {
            decimal totalAmount = ((students * papers) / 500) * price;

            Console.WriteLine("{0:F2}", totalAmount);
        }
    }
}
