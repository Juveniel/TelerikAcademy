using System;
using System.Text;

namespace _07.OneSystemToOther
{
    /// <summary>
    /// Write a program to convert the number N from any numeral system of 
    /// given base s to any other numeral system of base d.
    /// </summary>
    class OneSystemToOther
    {
        static void Main(string[] args)
        {
            string numToConvert = Console.ReadLine();
            long fromBase = long.Parse(Console.ReadLine().TrimStart('0'));
            long to = long.Parse(Console.ReadLine());

            string convertedNum = Convert(numToConvert, fromBase, to);
            Console.WriteLine(convertedNum);
        }

        private static string Convert(string numberToConvert, long from, long to)
        {
            long number = NToDecimal(numberToConvert, from);

            if (number == 0)
                return number.ToString();

            return DecimalToN(to, number);
        }

        private static string DecimalToN(long to, long number)
        {
            StringBuilder result = new StringBuilder();
            long remainder;
            char currentLetter;
            while (number > 0)
            {
                remainder = number % to;

                if (remainder < 10)
                    currentLetter = (char)(remainder + '0');
                else
                    currentLetter = (char)(remainder + 55);

                result.Insert(0, currentLetter);

                number /= to;
            }
            return result.ToString();
        }

        private static long NToDecimal(string numberToConvert, long from)
        {
            long number = 0;
            byte currentValue;
            numberToConvert = numberToConvert.ToUpper();

            for (int current = 0; current < numberToConvert.Length; current++)
            {
                number *= from;
                if (Char.IsLetter(numberToConvert[current]))
                    currentValue = (byte)(numberToConvert[current] - 55);
                else
                    currentValue = (byte)(numberToConvert[current] - '0');

                number += currentValue;
            }
            return number;
        }
    }
}
