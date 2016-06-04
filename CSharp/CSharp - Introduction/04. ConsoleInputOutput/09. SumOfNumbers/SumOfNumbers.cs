using System;

namespace _09.SumOfNumbers
{
    /// <summary>
    /// Write a program that enters a number N and after that 
    /// enters more N numbers and calculates and prints their sum.
    /// </summary>
    class SumOfNumbers
    {
        static void Main(string[] args)
        {
            int iterationsCount = int.Parse(Console.ReadLine());

            double sum = 0;
            for (int i = 1; i <= iterationsCount; i++)
            {
                double number = double.Parse(Console.ReadLine());
                sum += number;
            }

            Console.WriteLine("{0}", sum);
        }
    }
}
