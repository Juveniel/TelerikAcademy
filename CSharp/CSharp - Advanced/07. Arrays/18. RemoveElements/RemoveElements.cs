using System;
using System.Linq;

namespace _18.RemoveElements
{
    /// <summary>
    /// Write a program that reads an array of integers and removes from it a minimal number of elements 
    /// in such a way that the remaining array is sorted in increasing order. Print the minimal number 
    /// of elements that need to be removed in order for the array to become sorted.
    /// </summary>
    class RemoveElements
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int[] longestIncreasingSequence = new int[n];
            for (int i = 0; i < n; i++)
            {
                longestIncreasingSequence[i] = 1;
            }

            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (numbers[j] <= numbers[i])
                    {
                        longestIncreasingSequence[i] = Math.Max(longestIncreasingSequence[i], longestIncreasingSequence[j] + 1);
                    }
                }
            }

            Console.WriteLine(n - longestIncreasingSequence.Max());
        }
    }
}
