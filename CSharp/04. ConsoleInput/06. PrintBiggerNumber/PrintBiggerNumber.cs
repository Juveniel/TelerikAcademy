using System;

namespace _06.PrintBiggerNumber
{
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
