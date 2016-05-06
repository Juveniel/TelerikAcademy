using System;

namespace _08.MaximalSum
{
    /// <summary>
    /// Write a program that finds the maximal sum of 
    /// consecutive elements in a given array of N numbers.
    /// </summary>
    class MaximalSum
    {
        static void Main(string[] args)
        {
            int arrLength = int.Parse(Console.ReadLine());
            int[] numArr = new int[arrLength];

            for(int i = 0; i < arrLength; i++)
            {
                numArr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(FindMaxSumSequence(numArr));
        }

        private static int FindMaxSumSequence(int[] numbers)
        {
            int maxSequenceSum = 0;
            int tempSequenceSum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                tempSequenceSum += numbers[i];

                if (tempSequenceSum >= maxSequenceSum)
                {
                    maxSequenceSum = tempSequenceSum;
                }

                if (tempSequenceSum < 0)
                {
                    tempSequenceSum = 0;
                }
            }

            return maxSequenceSum;
        }
    }
}
