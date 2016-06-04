using System;

namespace _01.SumOfThreeNum
{
    /// <summary>
    /// Write a program that reads 3 real numbers from the console and prints their sum.
    /// </summary>
    class SumOfThreeNum
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            int sum = firstNum + secondNum + thirdNum;
            Console.WriteLine("{0}", sum);
        }
    }
}
