using System;
using System.Numerics;

namespace _08.CatalanNumbers
{
    /// <summary>
    /// Write a program that calculates the nth Catalan number by given N.
    /// </summary>
    class CatalanNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger catalanExp = (CalcFactorial(2 * n)) / (CalcFactorial(n + 1) * CalcFactorial(n));
            Console.WriteLine("{0}", catalanExp);
        }

        static BigInteger CalcFactorial(int n)
        {
            BigInteger nFactorial = 1;
            for (int i = 1; i <= n; i++)
            {
                nFactorial *= i;
            }

            return nFactorial;
        }
    }
}
