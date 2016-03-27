using System;

namespace _07.PrintINtegersSum
{
    /// <summary>
    /// Write a program that reads five integer numbers and prints their sum.
    /// If an invalid number is entered the program should prompt the user to enter another number.
    /// </summary>
    class PrintINtegersSum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of numbers to sum: ");
            int iterationsCount = CheckInputFormat(Console.ReadLine());

            long sum = 0;
            for(int i = 1; i <= iterationsCount; i++)
            {
                Console.WriteLine("Enter number {0}: ", i);
                int number = CheckInputFormat(Console.ReadLine());
                sum += number;
            }

            Console.WriteLine("The sum of the numbers is: {0}", sum);
        }

        static int CheckInputFormat(string input)
        {
            int result;
            while (!int.TryParse(input, out result))
            {
                Console.WriteLine("Please try again with a correct number: ");
                input = Console.ReadLine();
            }

            return int.Parse(input);
        }
    }
}
