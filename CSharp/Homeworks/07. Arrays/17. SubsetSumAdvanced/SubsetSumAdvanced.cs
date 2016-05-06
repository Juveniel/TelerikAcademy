using System;
using System.Collections.Generic;
using System.Linq;

namespace _17.SubsetSumAdvanced
{
    /// <summary>
    /// Write a program that reads three integer numbers N, K and S and an array of N elements from the console.
    /// Find in the array a subset of K elements that have sum S or indicate about its absence.
    /// </summary>
    class SubsetSumAdvanced
    {
        static void Main(string[] args)
        {

            long sumToCheck = long.Parse(Console.ReadLine());
            int subsetLength = int.Parse(Console.ReadLine());
            byte numberOfElements = byte.Parse(Console.ReadLine());

            long[] inputNumbers = new long[numberOfElements];

            for (int i = 0; i < inputNumbers.Length; i++)
            {
                inputNumbers[i] = int.Parse(Console.ReadLine());
            }

            int totalCombinations = (1 << numberOfElements) - 1;
            long subsetsCounter = 0;
            for (int i = 1; i < totalCombinations; i++)
            {
                List<long> subset = new List<long>();
                long sum = 0;
                int currSubCounter = 0;
                for (int j = 0; j <= numberOfElements; j++)
                {

                    if ((((1 << j) & i) >> j) == 1)
                    {
                        subset.Add(inputNumbers[j]);
                        sum += inputNumbers[j];
                        currSubCounter++;
                    }
                }

                if (subset.Sum() == sumToCheck && currSubCounter == subsetLength)
                {
                    subsetsCounter++;
                }
            }

            if (subsetsCounter == 0)
            {
                Console.WriteLine("subset is absent");
            }
            else
            {
                Console.WriteLine("yes: {0}", subsetsCounter);
            }
        }
    }
}
