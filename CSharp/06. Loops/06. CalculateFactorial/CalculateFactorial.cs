using System;
using System.Numerics;

namespace _06.CalculateFactorial
{
    /// <summary>
    /// Write a program that calculates N!/K! for given N and 1 < K < N
    /// </summary>
    class CalculateFactorial
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter thevalue of N:");
            int n = CheckInputFormat(Console.ReadLine());

            Console.WriteLine("Enter the value of K:");
            int k = CheckInputFormat(Console.ReadLine());

            BigInteger nFactorial = CalcFactorial(n);
            BigInteger kFactorial = CalcFactorial(k);

            Console.WriteLine("The result of the division is: {0}", nFactorial / kFactorial);
        }

        static int CheckInputFormat(string input)
        {
            int result;
            while (!int.TryParse(input, out result))
            {
                Console.WriteLine("Please try again with a correct number: ");
                input = Console.ReadLine();
            }

            return int.Parse(input);
        }

        static BigInteger CalcFactorial(int n)
        {
            BigInteger nFactorial = 1;
            for(int i = 1; i <= n; i++)
            {
                nFactorial *= i;
            }

            return nFactorial;
        }
    }
}
