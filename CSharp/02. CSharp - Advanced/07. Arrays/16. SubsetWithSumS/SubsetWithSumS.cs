﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _16.SubsetWithSumS
{
    /// <summary>
    /// We are given an array of integers and a number S. Write a program to find if 
    /// there exists a subset of the elements of the array that has a sum S.
    /// </summary>
    class SubsetWithSumS
    {
        static void Main(string[] args)
        {
            long sumToCheck = long.Parse(Console.ReadLine());
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
                for (int j = 0; j <= numberOfElements; j++)
                {

                    if ((((1 << j) & i) >> j) == 1)
                    {
                        subset.Add(inputNumbers[j]);
                    }
                }

                if (subset.Sum() == sumToCheck)
                {
                    subsetsCounter++;
                }
            }

            if (subsetsCounter == 0)
            {
                Console.WriteLine("no");
            }
            else
            {
                Console.WriteLine("yes");
            }
        }
    }    
}
