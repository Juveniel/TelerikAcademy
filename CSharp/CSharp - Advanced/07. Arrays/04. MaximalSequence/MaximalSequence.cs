using System;

namespace _04.MaximalSequence
{
    /// <summary>
    /// Write a program that finds the length of the maximal sequence 
    /// of equal elements in an array of N integers.
    /// </summary>
    class MaximalSequence
    {
        static void Main(string[] args)
        {
            int arrLength = int.Parse(Console.ReadLine());
            int[] numArr = new int[arrLength];

            for(int i = 0; i < arrLength; i++)
            {
                numArr[i] = int.Parse(Console.ReadLine());
            }

            int maxSequence = FindSequence(numArr);
            Console.WriteLine(maxSequence);
        }

        private static int FindSequence(int[] numbers)
        {
            int maxSequenceCount = 1;
            int tempSequenceCount = 1;

            for(int i = 0; i < numbers.Length - 1; i++)
            {
                if(numbers[i] == numbers[i + 1])
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
