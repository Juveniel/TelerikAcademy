using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.SubsetSum
{
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
