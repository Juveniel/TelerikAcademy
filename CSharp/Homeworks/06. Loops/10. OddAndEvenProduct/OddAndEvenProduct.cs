using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.OddAndEvenProduct
{
    /// <summary>
    /// You are given N integers (given in a single line, separated by a space).
    /// Checks whether the product of the odd elements is 
    /// equal to the product of the even elements.
    /// </summary>
    class OddAndEvenProduct
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());         
            var input = Console.ReadLine();

            List<long> userInput = ReceiveUserInput(input);
            long evenProduct = GetEvenProduct(userInput);
            long oddProduct = GetOddProduct(userInput);

            if(evenProduct == oddProduct)
            {
                Console.WriteLine("yes {0}", evenProduct);
            }
            else
            {
                Console.WriteLine("no {0} {1}", evenProduct, oddProduct );
            }
        }

        static List<long> ReceiveUserInput(string input)
        {
            var numbersArr = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var numbers = new List<long>();
            foreach (var num in numbersArr)
            {
                int result;
                if (!int.TryParse(num, out result))
                {
                    continue;
                }

                numbers.Add(result);
            }

            return numbers;
        }

        static long GetEvenProduct(List<long> numList)
        {
            return numList.Where((number, index) => index % 2 == 0).Aggregate((a, x) => a * x);
        }

        static long GetOddProduct(List<long> numList)
        {
            return numList.Where((number, index) => index % 2 != 0).Aggregate((a, x) => a * x);
        }
    }
}
