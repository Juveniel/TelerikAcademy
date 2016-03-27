using System;
using System.Numerics;

namespace _11.CountFactorialZeroes
{
    /// <summary>
    /// Write a program that calculates with how many zeros
    /// the factorial of a given number ends.
    /// </summary>
    class CountFactorialZeroes
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of N:");
            int userNumber = CheckInputFormat(Console.ReadLine());

            int trailingZerosCount = CountTrailigZeroes(userNumber);
            Console.WriteLine("N! = {0}", CalcFactorial(userNumber));
            Console.WriteLine("The count of trailing zeroes in N! is: {0}", trailingZerosCount);            
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
