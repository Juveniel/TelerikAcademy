using System;
using System.Collections.Generic;


namespace _11.Interval
{
    /// <summary>
    /// Write a program that reads two positive integer numbers N and M and 
    /// prints how many numbers exist between them such that the reminder of
    /// the division by 5 is 0.
    /// </summary>
    class Interval
    {
        static void Main(string[] args)
        {
            int inputFirstNum = int.Parse(Console.ReadLine());
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
            for (int i = start + 1 ; i < finish; i++)
            {
                if (i % 5 == 0)
                {
                    resList.Add(i);
                }
            }

            return resList;
        }

        static void DisplayNumbersList(List<int> numbers)
        {          
            Console.WriteLine(numbers.Count);
        }
    }
}
