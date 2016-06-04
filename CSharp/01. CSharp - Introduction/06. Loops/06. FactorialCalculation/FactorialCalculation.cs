using System;
using System.Numerics;

namespace _06.FactorialCalculation
{
    /// <summary>
    /// Write a program that calculates N! / K! for given N and K.
    /// </summary>
    class FactorialCalculation
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            BigInteger nFactorial = CalcFactorial(n);
            BigInteger kFactorial = CalcFactorial(k);

            Console.WriteLine("{0}", nFactorial / kFactorial);
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
