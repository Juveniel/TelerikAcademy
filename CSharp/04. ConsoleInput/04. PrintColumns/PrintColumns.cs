using System;

namespace _04.PrintColumns
{
    /// <summary>
    ///  Write a program that prints three numbers in three virtual columns on the console.
    ///  Each column should have a width of 10 characters and the numbers should be left aligned. 
    /// </summary>
    class PrintColumns
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your first number: ");      
            string hexValue = int.Parse(Console.ReadLine()).ToString("X");

            Console.Write("Enter a positive fractional number: ");
            double fractionPositiveNum = double.Parse(Console.ReadLine());

            Console.Write("Enter a negative fractional number: ");
            double fractionNegativeNum = double.Parse(Console.ReadLine());

            Console.Write("{0}", hexValue.ToString().PadRight(10, ' '));
            Console.Write("{0:F2}", fractionPositiveNum.ToString().PadRight(10, ' '));
            Console.Write("{0:F2}", fractionNegativeNum);
            Console.WriteLine();           
        }
    }
}
