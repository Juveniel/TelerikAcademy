using System;

namespace _10.PrintNumbersMatrix
{
    /// <summary>
    /// Write a program that reads from the console a positive integer N 
    /// and prints a matrix of numbers.
    /// </summary>
    class PrintNumbersMatrix
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of N: ");
            int n = CheckInputRange(int.Parse(Console.ReadLine()));

            for(int row = 1; row <= n; row++)
            {
                for(int col = row; col <= row + n -1; col++)
                {                  
                    Console.Write(col);
                }
                Console.WriteLine();
            }
        }

        static int CheckInputRange(int input)
        {
            while (input <= 0 || input > 20)
            {              
                Console.WriteLine("Please try again with a correct number [1..20]: ");
                input = int.Parse(Console.ReadLine());
            }

            return input;
        }
    }
}
