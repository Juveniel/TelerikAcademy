using System;

namespace _06.ReverseNumber
{
    /// <summary>
    /// Write a method that reverses the digits of a given decimal number.
    /// </summary>
    class ReverseNumber
    {
        static void Main(string[] args)
        {
            decimal numberToReverse = decimal.Parse(Console.ReadLine());

            char[] numberReversed = ReverseDigits(numberToReverse);
            PrintArray(numberReversed);
        }

        static char[] ReverseDigits(decimal number)
        {
            char[] numberDigits = number.ToString().ToCharArray();
            Array.Reverse(numberDigits);

            return numberDigits;
        }

        static void PrintArray(char[] digits)
        {
            for (int i = 0; i < digits.Length; i++)
            {
                Console.Write(digits[i]);
            }
            Console.WriteLine();
        }
    }
}
