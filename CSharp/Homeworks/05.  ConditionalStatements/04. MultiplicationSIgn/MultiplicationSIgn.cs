using System;
using System.Collections.Generic;

namespace _04.MultiplicationSIgn
{
    /// <summary>
    /// Write a program that shows the sign (+, - or 0) 
    /// of the product of three real numbers, without calculating it.
    /// </summary>
    class MultiplicationSIgn
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());
            double thirdNum = double.Parse(Console.ReadLine());

            List<double> inputList = new List<double>();
            inputList.Add(firstNum);
            inputList.Add(secondNum);
            inputList.Add(thirdNum);

            int negativeNumbersCount = 0;
            bool isZero = false;
            foreach (int number in inputList)
            {
                if (number < 0)
                {
                    negativeNumbersCount++;
                }

                if (number == 0)
                {
                    isZero = true;
                }
            }

            if (isZero)
            {
                Console.WriteLine("0");
            }
            else if (negativeNumbersCount % 2 == 0)
            {
                Console.WriteLine("+");
            }
            else
            {
                Console.WriteLine("-");
            }
        }
    }
}
