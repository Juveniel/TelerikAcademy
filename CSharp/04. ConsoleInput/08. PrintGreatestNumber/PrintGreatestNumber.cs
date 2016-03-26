using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.PrintGreatestNumber
{
    class PrintGreatestNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of numbers to iterate: ");
            int iterationsCount = CheckInputFormat(Console.ReadLine());

            List<int> inputList = new List<int>();
            for (int i = 1; i <= iterationsCount; i++)
            {
                Console.WriteLine("Enter number {0}: ", i);
                int number = CheckInputFormat(Console.ReadLine());
                inputList.Add(number);
            }

            int maxInput = inputList.Max();

            Console.WriteLine("The biggest numbers of the collection is: {0}", maxInput);
        }

        static int CheckInputFormat(string input)
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
