using System;

namespace _01.NumbersOneToN
{
    /// <summary>
    /// Write a program that enters from the console a positive integer n and 
    /// prints all the numbers from 1 to N inclusive, on a single line, separated by a whitespace.
    /// </summary>
    class NumbersOneToN
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
