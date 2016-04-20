using System;

namespace _05.Calculation
{
    /// <summary>
    /// Write a program that, for a given two integer numbers N and x, 
    /// calculates the sum S = 1 + 1!/x + 2!/x<sup>2</sup> + … + n!/x<sup>N</sup>.
    /// </summary>
    class Calculation
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());

            double expressionSum = 1;
            for (int i = 1; i <= n; i++)
            {
                expressionSum += CalcFactorial(i) / Math.Pow(x, i);
            }

            Console.WriteLine("{0:F5}", expressionSum);
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
