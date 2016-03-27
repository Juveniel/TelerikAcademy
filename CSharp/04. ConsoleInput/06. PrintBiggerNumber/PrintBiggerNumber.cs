using System;

namespace _06.PrintBiggerNumber
{
    /// <summary>
    /// Write a program that reads two numbers from the console and prints
    /// the greater of them. Solve the problem without using conditional statements.
    /// </summary>
    class PrintBiggerNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            int firstNum = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            int secondNum = int.Parse(Console.ReadLine());

            Console.WriteLine("The bigger number is: {0}", Math.Max(firstNum, secondNum));
        }
    }
}
