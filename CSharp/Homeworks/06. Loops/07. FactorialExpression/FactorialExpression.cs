using System;

namespace _07.FactorialExpression
{
    /// <summary>
    /// Write a program that calculates N!*K!/(N-K)
    /// </summary>
    class FactorialExpression
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            int nFactorial = CalcFactorial(n);
            int kFactorial = CalcFactorial(k);
            int nkFactiral = CalcFactorial(n - k);

            int expression = (nFactorial * kFactorial) / nkFactiral;
            Console.WriteLine("{0}", expression);
        }

        static int CalcFactorial(int n)
        {
            int nFactorial = 1;
            for (int i = 1; i <= n; i++)
            {
                nFactorial *= i;
            }

            return nFactorial;
        }
    }
}
