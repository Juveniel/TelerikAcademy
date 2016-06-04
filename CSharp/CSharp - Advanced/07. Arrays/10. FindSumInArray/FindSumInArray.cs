using System;
using System.Collections.Generic;

namespace _10.FindSumInArray
{
    /// <summary>
    /// Write a program that finds in given array of integers 
    /// a sequence of given sum S (if present).
    /// </summary>
    class FindSumInArray
    {
        static void Main(string[] args)
        {
            int arrLength = int.Parse(Console.ReadLine());
            int sumToSearch = int.Parse(Console.ReadLine());

            int[] numArr = new int[arrLength];

            for(int i = 0; i < numArr.Length; i++)
            {
                numArr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(FindSequenceOfSum(numArr, sumToSearch));   
        }

        private static string FindSequenceOfSum(int[] numbers, int sumToSearch)
        {
            string sequence = "";
            bool foundSequence = false;

            List<int> sequenceList = new List<int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                int sum = 0;

                if (foundSequence)
                {
                    break;
                }

                for (int j = i; j < numbers.Length; j++)
                {
                    sum += numbers[j];
                    sequenceList.Add(numbers[j]);
                    if (sum > sumToSearch)
                    {
                        sequenceList.Clear();
                        sum = 0;
                        break;
                    }

                    if (sum == sumToSearch)
                    {
                        sequence = string.Join(",", sequenceList);
                        foundSequence = true;
                        break;
                    }
                }
            }

            return sequence;
        }
    }
}
