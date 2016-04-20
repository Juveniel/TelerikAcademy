using System;
using System.Numerics;

namespace _07.FactorialExpression
{
    /// <summary>
    /// Write a program that calculates N!*K!/(N-K)
    /// </summary>
    class FactorialExpression
    {
        static void Main(string[] args)
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            BigInteger k = BigInteger.Parse(Console.ReadLine());

            BigInteger nFactorial = CalcFactorial(n);
            BigInteger kFactorial = CalcFactorial(k);
            BigInteger nkFactiral = CalcFactorial(n - k);

            BigInteger expression = nFactorial / (kFactorial * (nkFactiral));
            Console.WriteLine("{0}", expression);
        }

        static BigInteger CalcFactorial(BigInteger n)
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
