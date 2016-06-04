using System;

namespace _06.MaximalKSum
{
    /// <summary>
    /// Write a program that reads two integer numbers N and K 
    /// and an array of N elements from the console. 
    /// Find the maximal sum of K elements in the array.
    /// </summary>
    class MaximalKSum
    {
        static void Main(string[] args)
        {
            int arrLength = int.Parse(Console.ReadLine());
            int kElement = int.Parse(Console.ReadLine());

            int[] numArr = new int[arrLength];
            for(int i = 0; i < numArr.Length; i++)
            {
                numArr[i] = int.Parse(Console.ReadLine());
            }

            int maxSum = FindMaximalSum(numArr, kElement);
            Console.WriteLine(maxSum);
        }

        private static int FindMaximalSum(int[] numArr, int kElement)
        {
            Array.Sort(numArr);

            int maxSum = int.MinValue;
            int tempSum = 0;

            for(int i = 0; i < numArr.Length + 1 - kElement; i++)
            {
                for (int j = 0; j < kElement; j++)
                {
                    tempSum += numArr[j + i];               
                }

                if (tempSum > maxSum)
                {
                    maxSum = tempSum;
                }
                               
                tempSum = 0;                            
            }

            return maxSum;
        }
    }
}
