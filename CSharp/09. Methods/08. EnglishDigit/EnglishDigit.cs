using System;

namespace _08.EnglishDigit
{
    /// <summary>
    /// Write a method that returns the last digit of given integer as an English word.
    /// Write a program that reads a number and prints the result of the method.
    /// </summary>
    class EnglishDigit
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            string lastDigitAsWord = LastDigitToWord(number);
            Console.WriteLine(lastDigitAsWord);
        }

        private static string LastDigitToWord(int number)
        {
            string[] tensMap = new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };            
            int lastDigit = number % 10;
            string word = tensMap[lastDigit];

            return word;
        }
    }
}
