using System;

namespace _09.SortingArray
{
    /// <summary>
    /// Write a method that returns the maximal element in a portion of array of integers
    /// starting at given index. Using it write another method that sorts an array in 
    /// ascending / descending order. Write a program that sorts a given array.
    /// </summary>
    class SortingArray
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[] numbers = FillArray(size);

            int[] sortedArr = SortArray(numbers, "ASC");
            foreach (var num in sortedArr)
            {
                Console.Write(num + " ");
            }
        }

        static int[] FillArray(int size)
        {
            int[] arrNumbers = new int[size];
            var line = Console.ReadLine().Split(' ');

            for (int i = 0; i < size; i++)
            {                
                arrNumbers[i] = int.Parse(line[i]);
            }

            return arrNumbers;
        }

        static int[] SortArray(int[] numbers, string direction)
        {
            Array.Sort(numbers);

            if(direction == "DESC")
            {
                Array.Reverse(numbers);
            }

            return numbers;
        }

    }
}
