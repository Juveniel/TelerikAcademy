using System;

namespace _15.GreatestCommonDivisor
{
    /// <summary>
    /// Write a program that calculates the greatest common
    /// divisor (GCD) of given two integers A and B.
    /// </summary>
    class GreatestCommonDivisor
    {
        static void Main(string[] args)
        {          
            string input = Console.ReadLine();
            var numbersArr = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            long firstNum = Math.Abs(long.Parse(numbersArr[0]));
            long secondNum = Math.Abs(long.Parse(numbersArr[1]));

            var gcd = FindGCD(firstNum, secondNum);
            Console.WriteLine(gcd);
        }

        static long FindGCD(long a, long b)
        {
            long Remainder;

            while (b != 0)
            {
                Remainder = a % b;
                a = b;
                b = Remainder;
            }

            return a;
        }
    }
}
