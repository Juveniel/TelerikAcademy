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
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            var gcd = FindGCD(firstNum, secondNum);
            Console.WriteLine(gcd);
        }

        static int FindGCD(int a, int b)
        {
            int Remainder;

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
