using System;

namespace _03.CalcDecimal
{
    class CalcDecimal
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter two decimal numbers:");
            decimal firstNum = decimal.Parse(Console.ReadLine());
            decimal secondNum = decimal.Parse(Console.ReadLine());
            decimal sum = firstNum + secondNum;
            Console.WriteLine(sum);
        }
    }
}
