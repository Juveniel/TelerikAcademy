using System;
using System.Numerics;

namespace _16.TrailingZeroes
{
    /// <summary>
    /// Write a program that calculates with how many zeros
    /// the factorial of a given number ends.
    /// </summary>
    class TrailingZeroes
    {
        static void Main(string[] args)
        {
            int userNumber = CheckInputFormat(Console.ReadLine());

            int trailingZerosCount = CountTrailigZeroes(userNumber);
            Console.WriteLine("{0}", trailingZerosCount);
        }

        static int CountTrailigZeroes(int num)
        {
            int count = 0;
            for (int i = 5; num / i >= 1; i *= 5)
            {
                count += num / i;
            }

            return count;
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
            for (uint i = 1; i <= n; i++)
            {
                nFactorial *= i;
            }

            return nFactorial;
        }
    }
}
