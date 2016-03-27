using System;

namespace _03.CompareNumbers
{
    /// <summary>
    /// Write a program that finds the biggest of three integers, using nested if statements.
    /// </summary>
    class CompareNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            int firstNum = CheckInputFormat(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            int secondNum = CheckInputFormat(Console.ReadLine());

            Console.WriteLine("Enter third number: ");
            int thirdNum = CheckInputFormat(Console.ReadLine());

            int biggestNumber = 0;
            if(firstNum > secondNum)
            {
                if(firstNum > thirdNum)
                {
                    biggestNumber = firstNum;
                }
                else
                {
                    biggestNumber = thirdNum;
                }
            }
            else
            {
                if(secondNum > thirdNum)
                {
                    biggestNumber = secondNum;
                }
                else
                {
                    biggestNumber = thirdNum;
                }
            }

            Console.WriteLine("The biggest number of three is: {0}", biggestNumber);
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
