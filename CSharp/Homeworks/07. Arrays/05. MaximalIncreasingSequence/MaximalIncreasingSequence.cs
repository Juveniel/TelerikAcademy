using System;

namespace _05.MaximalIncreasingSequence
{
    /// <summary>
    /// Write a program that finds the length of the maximal
    /// increasing sequence in an array of N integers.
    /// </summary>
    class MaximalIncreasingSequence
    {
        static void Main(string[] args)
        {
            int arrLength = int.Parse(Console.ReadLine());
            int[] numArr = new int[arrLength];

            for(int i = 0; i < arrLength; i++)
            {
                numArr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(FindMaxIncreasingSeq(numArr));
        }

        private static int FindMaxIncreasingSeq(int[] nums)
        {
            int maxSequenceCount = 1;
            int tempSequenceCount = 1;

            for(int i = 0; i< nums.Length - 1; i++)
            {
                if(nums[i] < nums[i + 1])
                {
                    tempSequenceCount++;
                }
                else
                {
                    tempSequenceCount = 1;
                }

                if (tempSequenceCount >= maxSequenceCount)
                {
                    maxSequenceCount = tempSequenceCount;
                }
            }

            return maxSequenceCount;
        }
    }
}
