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
            int n = int.Parse(Console.ReadLine());         
            var input = Console.ReadLine();

            List<int> userInput = ReceiveUserInput(input);
            int evenProduct = GetEvenProduct(userInput);
            int oddProduct = GetOddProduct(userInput);

            if(evenProduct == oddProduct)
            {
                Console.WriteLine("yes {0}", evenProduct);
            }
            else
            {
                Console.WriteLine("no {0} {1}", oddProduct, evenProduct);
            }
        }

        static List<int> ReceiveUserInput(string input)
        {
            var numbersArr = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var numbers = new List<int>();
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

        static int GetEvenProduct(List<int> numList)
        {
            return numList.Where((number, index) => index % 2 == 0).Aggregate((a, x) => a * x);
        }

        static int GetOddProduct(List<int> numList)
        {
            return numList.Where((number, index) => index % 2 != 0).Aggregate((a, x) => a * x);
        }
    }
}
