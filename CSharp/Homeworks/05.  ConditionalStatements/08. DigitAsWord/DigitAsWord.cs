using System;
using System.Text.RegularExpressions;

namespace _08.DigitAsWord
{
    /// <summary>
    /// Write a program that read a digit (0-9) from the console, and d
    /// epending on the input, shows the digit as a word (in English).
    /// </summary>
    class DigitAsWord
    {
        static void Main(string[] args)
        {
            double inputNumber = CheckInputFormat(Console.ReadLine());

            string numberToWord = "";
            switch (int.Parse(inputNumber.ToString()))
            {
                case 1:
                    numberToWord = "one";
                    break;
                case 2:
                    numberToWord = "two";
                    break;
                case 3:
                    numberToWord = "three";
                    break;
                case 4:
                    numberToWord = "four";
                    break;
                case 5:
                    numberToWord = "five";
                    break;
                case 6:
                    numberToWord = "six";
                    break;
                case 7:
                    numberToWord = "seven";
                    break;
                case 8:
                    numberToWord = "eight";
                    break;
                case 9:
                    numberToWord = "nine";
                    break;
                default:
                    numberToWord = "zero";
                    break;
            }

            Console.WriteLine(numberToWord);
        }

        public static double CheckInputFormat(string input)
        {
            double result;
            bool isValid = Regex.IsMatch(input, "^[0-9]+$") && input.Length == 1;

            if(!isValid)
            {
                Console.WriteLine("not a digit");
                Environment.Exit(1);
            }

            return double.Parse(input);
        }
    }
}
