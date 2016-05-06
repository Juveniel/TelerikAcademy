using System;

namespace _11.BinarySearch
{
    /// <summary>
    /// Write a program that finds the index of given element X in 
    /// a sorted array of N integers by using the Binary search algorithm.
    /// </summary>
    class BinarySearch
    {
        static void Main(string[] args)
        {
            int arrLength = int.Parse(Console.ReadLine());
            int[] numArr = new int[arrLength];

            for(int i = 0; i < numArr.Length; i++)
            {
                numArr[i] = int.Parse(Console.ReadLine());
            }

            int numberToFind = int.Parse(Console.ReadLine());

            Console.WriteLine(FindWithBinarySearch(numArr, numberToFind));        
        }

        private static int FindWithBinarySearch(int[] numbers, int numberToFind)
        {
           // Array.Sort(numbers);
            int first = 0;
            int last = numbers.Length - 1;
            int foundPosition = -1;
            bool found = false;
            
            while (!found && first <= last)
            {
                int mid = (first + last) / 2;

                if (numbers[mid] < numberToFind)
                {
                    first = mid + 1;
                }
                else if (numbers[mid] > numberToFind)
                {
                    last = mid - 1;
                }
                else
                {
                    found = true;
                    foundPosition = mid;
                    break;
                }
            }

            return foundPosition;
        }
    }
}
