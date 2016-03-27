using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.SubsetSum
{
    /// <summary>
    /// We are given 5 integer numbers. Write a program that 
    /// finds those subsets whose sum is 0. Examples:
    /// - If we are given the numbers {3, -2, 1, 1, 8}, the sum of -2, 1 and 1 is 0.
    /// - If we are given the numbers {3, 1, -7, 35, 22}, there are no subsets with sum 0.
    /// </summary>
    class SubsetSum
    {       
        static void Main(string[] args)
        {
            // Receive user input
            Console.WriteLine("Enter the sum of the subsets to check:");
            int sumToCheck = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of elements:");
            int numberOfElements = int.Parse(Console.ReadLine());
            var inputNumbers = new int[numberOfElements];

            for (int i = 0; i < inputNumbers.Length; i++)
            {
                Console.WriteLine("Enter element № {0}", i + 1);
                inputNumbers[i] = int.Parse(Console.ReadLine());
            }
            
            int totalCombinations = (1 << numberOfElements) - 1; // Total combinations with complexity(2^n - 1)
            int subsetsCounter = 0;
            for (int i = 1; i < totalCombinations; i++)
            {
                List<int> subset = new List<int>();
                for (int j = 0; j <= numberOfElements; j++)
                {

                    if((((1 << j) & i) >> j) == 1){ // bit masking algo
                        subset.Add(inputNumbers[j]);
                    }                   
                }

                if (subset.Sum() == 0)
                {
                    subsetsCounter++;
                    Console.WriteLine(string.Join(" ", subset));
                }
            }

            if(subsetsCounter == 0)
            {
                Console.WriteLine("No subsets found!");
            }
        }         
    }
}
