using System;

namespace _09.MatrixOfNumbers
{
    /// <summary>
    /// Write a program that reads from the console a positive integer number N and p
    /// rints a matrix like in the examples below. Use two nested loops.
    /// </summary>
    class MatrixOfNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                for (int col = row; col <= row + n - 1; col++)
                {
                    Console.Write(col);
                }
                Console.WriteLine();
            }
        }
    }
}
