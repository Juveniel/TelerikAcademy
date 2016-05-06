using System;

namespace _05.NumberComparer
{
    /// <summary>
    /// Write a program that gets two numbers from 
    /// the console and prints the greater of them.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());

            Console.WriteLine("{0}", Math.Max(firstNum, secondNum));
        }
    }
}
