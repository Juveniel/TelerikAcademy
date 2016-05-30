using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.EnterNumbers
{
    /// <summary>
    /// Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end]. 
    /// If an invalid number or non-number text is entered, the method should throw an exception.
    /// </summary>
    class EnterNumbers
    {
        static List<int> numbers = new List<int>();
        static string exceptionMessage = "Exception";

        static void Main()
        {
            int min = 0;
            int max = 100;

            try
            {
                for (int i = 0; i < 10; i++)
                {
                    numbers.Add(ReadNumber(min, max));
                }

                if (!CheckNumbersAscending())
                {
                    throw new Exception(exceptionMessage);
                }

                PrintResult();
            }    
            catch (Exception)
            {
                Console.WriteLine(exceptionMessage);
            }                        
        }

        private static int ReadNumber(int start, int end)
        {
            if (start > end)
            {
                throw new ArgumentException(exceptionMessage);
            }
            int firstNumber = int.Parse(Console.ReadLine());
            if (firstNumber >= 100 || firstNumber <= 1)
            {
                throw new ArgumentOutOfRangeException(exceptionMessage);
            }

            return firstNumber;
        }

        private static bool CheckNumbersAscending()
        {
            bool numbersAscending = true;

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] > numbers[i + 1])
                {
                    numbersAscending = false;
                    break;
                }
            }

            return numbersAscending;
        }

        private static void PrintResult()
        {
            var output = new StringBuilder();      
            output.Append("1 < ");
            output.Append(string.Join(" < ", numbers.Select(n => n.ToString()).ToArray()));
            output.Append(" < 100");

            Console.WriteLine(output.ToString());            
        }
    }
}
