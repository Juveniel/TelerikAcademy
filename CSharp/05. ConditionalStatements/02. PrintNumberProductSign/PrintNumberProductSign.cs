using System;
using System.Collections.Generic;

namespace _02.PrintNumberProductSign
{
    class PrintNumberProductSign
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            int firstNum = CheckInputFormat(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            int secondNum = CheckInputFormat(Console.ReadLine());

            Console.WriteLine("Enter third number: ");
            int thirdNum = CheckInputFormat(Console.ReadLine());

            List<int> inputList = new List<int>();
            inputList.Add(firstNum);
            inputList.Add(secondNum);
            inputList.Add(thirdNum);

            int negativeNumbersCount = 0;
            bool isZero = false;
            foreach(int number in inputList)
            {
                if(number < 0)
                {
                    negativeNumbersCount++;
                }

                if(number == 0)
                {
                    isZero = true;
                }
            }

            Console.Write("The result is: ");
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

        public static int CheckInputFormat(string input)
        {
            int result;
            while (!int.TryParse(input, out result))
            {
                Console.WriteLine("Please try again with a correct number: ");
                input = Console.ReadLine();
            }

            return int.Parse(input);
        }
    }
}
