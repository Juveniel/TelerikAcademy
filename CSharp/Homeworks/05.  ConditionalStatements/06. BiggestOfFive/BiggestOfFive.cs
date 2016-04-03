using System;

namespace _06.BiggestOfFive
{
    /// <summary>
    /// Write a program that finds the biggest of 5 numbers that 
    /// are read from the console, using only 5 if statements.
    /// </summary>
    class BiggestOfFive
    {
        static void Main(string[] args)
        {
            double[] numberArr = new double[5];
            for(int i = 0; i < numberArr.Length; i++)
            {
                numberArr[i] = double.Parse(Console.ReadLine());
            }        

            double maxValue = 0;
            for (int i = 0; i < numberArr.Length; i++)
            {
                double currentNum = numberArr[i];
                if (currentNum > maxValue)
                {
                    maxValue = currentNum;
                }
            }

            Console.WriteLine("{0}", maxValue);
        }
    }
}
