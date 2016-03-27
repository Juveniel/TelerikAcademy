﻿using System;

namespace _10.BonusPoints
{
    /// <summary>
    /// Write a program that applies bonus points to 
    /// given scores in the range [1…9] by the following rules:
    /// - If the score is between 1 and 3, the program multiplies it by 10.
    /// - If the score is between 4 and 6, the program multiplies it by 100.
    /// - If the score is between 7 and 9, the program multiplies it by 1000.
    /// - If the score is 0 or more than 9, the program prints an error message.
    /// </summary>
    class BonusPoints
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your score: ");
            int userScore = CheckInputRange(int.Parse(Console.ReadLine()));

            switch (userScore)
            {
                case 1:
                case 2:
                case 3:
                    userScore *= 10;
                    break;
                case 4:
                case 5:
                case 6:
                    userScore *= 100;
                    break;
                case 7:
                case 8:
                case 9:
                    userScore *= 1000;
                    break;
                default:
                    Console.WriteLine("Invalid score!");
                    break;
            }

            Console.WriteLine("Your final score (including bonus points) is: {0}", userScore);
        }

        static int CheckInputRange(int input)
        {
            while(input < 1 || input > 9)
            {
                Console.WriteLine("Please enter a correct score in range [0-9]");
                input = int.Parse(Console.ReadLine());
            }

            return input;
        }
    }
}
