using System;

namespace _14.QuickSortArr
{
    /// <summary>
    /// Write a program that sorts an array of integers
    /// using the Quick sort algorithm.
    /// </summary>
    class QuickSortArr
    {
        static void Main(string[] args)
        {
            int arrLength = int.Parse(Console.ReadLine());
            int[] numArr = new int[arrLength];

            for (int i = 0; i < numArr.Length; i++)
            {
                numArr[i] = int.Parse(Console.ReadLine());
            }

            QuickSort(numArr, 0, numArr.Length - 1);

            foreach (int num in numArr)
            {
                Console.WriteLine(num);
            }
        }

        public static void QuickSort(int[] elements, int left, int right)
        {
            
        }
    }
}
