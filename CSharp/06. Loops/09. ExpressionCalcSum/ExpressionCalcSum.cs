using System;

namespace _09.ExpressionCalcSum
{
    /// <summary>
    /// Write a program that for a given integers n and x calculates the sum
    /// S = 1 + 1!/x + 2!/x2 ... n!/xn
    /// </summary>
    class ExpressionCalcSum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter thevalue of N:");
            uint n = CheckInputFormat(Console.ReadLine());

            Console.WriteLine("Enter the value of X:");
            uint x = CheckInputFormat(Console.ReadLine());

            double expressionSum = 0;
            for(uint i = 1; i <= n; i++)
            {
                expressionSum += CalcFactorial(i) / Math.Pow(x, i);
            }

            Console.WriteLine(expressionSum);
        }

        static uint CheckInputFormat(string input)
        {
            uint result;
            while (!uint.TryParse(input, out result))
            {
                Console.WriteLine("Please try again with a correct number: ");
                input = Console.ReadLine();
            }

            return uint.Parse(input);
        }

        static uint CalcFactorial(uint n)
        {
            uint nFactorial = 1;
            for (uint i = 1; i <= n; i++)
            {
                nFactorial *= i;
            }

            return nFactorial;
        }
    }
}
