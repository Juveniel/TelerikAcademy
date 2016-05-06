using System;

namespace _01.ExchangeNumbers
{
    /// <summary>
    /// Write a program that reads two double values from the console A and B,
    /// stores them in variables and exchanges their values if the first 
    /// one is greater than the second one.
    /// </summary>
    class ExchangeNumbers
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            if (firstNum > secondNum)
            {
                firstNum = firstNum + secondNum;
                secondNum = firstNum - secondNum;
                firstNum = firstNum - secondNum;

            }

            Console.WriteLine("{0} {1}", firstNum, secondNum);
        }
    }
}
