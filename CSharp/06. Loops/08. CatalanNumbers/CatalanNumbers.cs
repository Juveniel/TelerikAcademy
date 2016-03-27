using System;

namespace _08.CatalanNumbers
{
    /// <summary>
    /// Write a program that calculates the nth Catalan number by given N.
    /// </summary>
    class CatalanNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of N to find Catalan numbers: ");
            decimal n = CheckInputFormat(Console.ReadLine());

            decimal catalanExp = (CalcFactorial(2 * n)) / (CalcFactorial(n + 1) * CalcFactorial(n));
            Console.WriteLine("Catalan nth num: {0}", catalanExp);
        }

        static decimal CheckInputFormat(string input)
        {
            decimal result;
            while (!decimal.TryParse(input, out result))
            {
                Console.WriteLine("Please try again with a correct number: ");
                input = Console.ReadLine();
            }

            return decimal.Parse(input);
        }

        static decimal CalcFactorial(decimal n)
        {
            decimal nFactorial = 1;
            for (int i = 1; i <= n; i++)
            {
                nFactorial *= i;
            }

            return nFactorial;
        }
    }
}
