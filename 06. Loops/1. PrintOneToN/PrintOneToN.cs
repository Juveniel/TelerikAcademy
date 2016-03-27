using System;

namespace _1.PrintOneToN
{
    /// <summary>
    /// Write a program that prints on the console the numbers from 1 to N.
    /// The number N should be read from the standart input.
    /// </summary>

    class PrintOneToN
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of n:");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
