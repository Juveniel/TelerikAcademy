using System;

namespace _08.NumbersOneToN
{
    /// <summary>
    /// Write a program that reads an integer number N from the 
    /// console and prints all the numbers in the interval [1, n], each on a single line.
    /// </summary>
    class NumbersOneToN
    {
        static void Main(string[] args)
        {
            int upperBoundary = int.Parse(Console.ReadLine());

            for (int i = 1; i <= upperBoundary; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
