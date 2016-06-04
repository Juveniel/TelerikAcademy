﻿using System;

namespace _02.NotDivisibleNumbers
{
    /// <summary>
    /// Write a program that reads from the console a positive integer N 
    /// and prints all the numbers from 1 to N not divisible by 3 or 7,
    /// on a single line, separated by a space.
    /// </summary>
    class NotDivisibleNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if ((i % 3 != 0) && (i % 7 != 0))
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
