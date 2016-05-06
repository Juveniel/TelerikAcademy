using System;
using System.Numerics;

namespace _10.NFactorial
{
    /// <summary>
    /// Write a method that multiplies a number represented as an array 
    /// of digits by a given integer number. Write a program to calculate N!.
    /// </summary>
    class NFactorial
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger factorialOfN = CalcFactorial(n);
            Console.WriteLine(factorialOfN);
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
