using System;

namespace _01.ExchangeValues
{
    class ExchangeValues
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            int firstNum = CheckInputFormat(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            int secondNum = CheckInputFormat(Console.ReadLine());

            if(firstNum > secondNum)
            {
                firstNum = firstNum + secondNum;
                secondNum = firstNum - secondNum;
                firstNum = firstNum - secondNum;

            }

            Console.WriteLine("First number = {0}", firstNum);
            Console.WriteLine("Second number = {0}", secondNum);
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
