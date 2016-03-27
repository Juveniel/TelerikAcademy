﻿using System;

namespace _11.NumbersAsWordsExtended
{
    /// <summary>
    /// Write a program that converts a number in the range [0…999] to words, 
    /// corresponding to the English pronunciation. Examples:
    /// </summary>
    class NumbersAsWordsExtended
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number in range [0...999]");
            int inputNum = CheckInputRange(int.Parse(Console.ReadLine()));

            var singles = new[] { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten" };
        }

        static int CheckInputRange(int input)
        {
            while (input < 1 || input > 999)
            {
                Console.WriteLine("Please enter a correct score in range [0-9]");
                input = int.Parse(Console.ReadLine());
            }

            return input;
        }
    }
}
