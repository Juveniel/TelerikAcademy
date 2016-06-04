﻿using System;

namespace _03.DivisionBySevenAndFive
{
    /// <summary>
    /// Write a program that does the following:
    /// - Reads an integer number from the console.
    /// - Stores in a variable if the number can be divided by 7 and 5 without remainder.
    /// - Prints on the console "true NUMBER" if the number is divisible without remainder 
    /// by 7 and 5. Otherwise prints "false NUMBER". In place of NUMBER print the value of the input number. 
    /// </summary>
    class DivisionBySevenAndFive
    {
        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());

            if (inputNum % 5 == 0 && inputNum % 7 == 0)
            {
                Console.WriteLine("true {0}", inputNum);
            }
            else {
                Console.WriteLine("false {0}", inputNum);
            }
        }
    }
}
