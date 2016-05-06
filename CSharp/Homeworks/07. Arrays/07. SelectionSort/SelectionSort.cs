using System;

namespace _07.SelectionSort
{
    /// <summary>
    /// Write a program to sort an array. Use the Selection sort algorithm:
    /// </summary>
    class SelectionSort
    {
        static void Main(string[] args)
        {
            int arrLength = int.Parse(Console.ReadLine());
            int[] numArr = new int[arrLength];

            for(int i = 0; i < numArr.Length; i++)
            {
                numArr[i] = int.Parse(Console.ReadLine());
            }

            PrintResult(SelectionSortArr(numArr));
        }

        private static int[] SelectionSortArr(int[] numArr)
        {
            for (int i = 0; i < numArr.Length - 1; i++)
            {
                for (int j = i + 1; j < numArr.Length; j++)
                {
                    if (numArr[i] > numArr[j]) 
                    {
                        int tmp = numArr[i];
                        numArr[i] = numArr[j];
                        numArr[j] = tmp;
                    }
                }
            }

            return numArr;
        }

        private static void PrintResult(int[] sorted)
        {
            for(int i = 0; i < sorted.Length; i++)
            {
                Console.WriteLine(sorted[i]);
            }
        }
    }
}
