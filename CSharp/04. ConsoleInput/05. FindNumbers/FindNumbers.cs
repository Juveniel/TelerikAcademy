using System;
using System.Collections.Generic;

namespace _05.FindNumbers
{
    /// <summary>
    /// Write a program that reads from the console two integer numbers
    /// (int) and prints how many numbers between them exist, such that 
    /// the remainder of their division by 5 is 0.
    /// </summary>
    class FindNumbers
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int inputFirstNum = int.Parse(Console.ReadLine());

            Console.Write("Enter your second number: ");
            int inputSecondNum = int.Parse(Console.ReadLine());

            var numbersList = GetNumsWithoutRemainder(inputFirstNum, inputSecondNum);
            DisplayNumbersList(numbersList);
         
        }

        static bool IsInteger(string input)
        {
            int num;
            bool isInteger = int.TryParse(input, out num);

            return isInteger;
        }

        static List<int> GetNumsWithoutRemainder(int start, int finish)
        {
            List<int> resList = new List<int>();
            for(int i = start; i <= finish; i++)
            {
                if(i % 5 == 0)
                {
                    resList.Add(i);
                }
            }

            return resList;
        }

        static void DisplayNumbersList(List<int> numbers)
        {
            Console.Write("The numbers are: ");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");                  
            }
            Console.WriteLine();
        }
    }
}
