using System;

using System.Text.RegularExpressions;

namespace _05.NumberAsWords
{
    class NumberAsWords
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number from 0 to 9: ");
            int inputNumber = CheckInputFormat(Console.ReadLine());

            string numberToWord = "";
            switch (inputNumber)
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

        public static int CheckInputFormat(string input)
        {
            int result;
            bool isValid = Regex.IsMatch(input, "^[0-9]+$") && input.Length == 1;

            while (!isValid)
            {
                Console.WriteLine("Please try again with a correct number: ");
                input = Console.ReadLine();
                isValid = Regex.IsMatch(input, "^[0-9]+$") && input.Length == 1;
            }

            return int.Parse(input);
        }
    }
}
