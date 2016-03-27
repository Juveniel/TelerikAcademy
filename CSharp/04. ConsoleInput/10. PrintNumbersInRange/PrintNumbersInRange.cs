using System;

namespace _10.PrintNumbersInRange
{
    /// <summary>
    /// Write a program that reads an integer number n from the console 
    /// and prints all numbers in the range [1…n], each on a separate line.
    /// </summary>
    class PrintNumbersInRange
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number for boundary: ");
            int upperBoundary = CheckInputFormat(Console.ReadLine());

            Console.WriteLine("===///=== RESULT ===///===");
            for(int i = 1; i <= upperBoundary; i++)
            {
                Console.WriteLine(i);
            }
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
