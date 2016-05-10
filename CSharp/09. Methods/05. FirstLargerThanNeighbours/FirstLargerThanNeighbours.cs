using System;
using System.Linq;

namespace _05.FirstLargerThanNeighbours
{
    /// <summary>
    /// Write a method that returns the index of the first element in array that
    /// is larger than its neighbours, or -1, if there is no such element.
    /// </summary>
    class FirstLargerThanNeighbours
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[] delimiter = new char[] { ',', ' ' };
            int[] numbersArr = Console.ReadLine().Split(delimiter, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            PrintFirstFound(numbersArr);
        }

        static bool IsBiggerThanNeighbours(int[] testArr, int testPosition)
        {
            bool isBigger = false;
            if (testPosition == 0)
            {
                isBigger = false;
            }
            else if (testPosition == testArr.Length - 1)
            {

                isBigger = false;
            }
            else
            {
                if (testArr[testPosition] > testArr[testPosition - 1] && testArr[testPosition] > testArr[testPosition + 1])
                {
                    isBigger = true;
                }
            }

            return isBigger;
        }

        static void PrintFirstFound(int[] arr)
        {
            bool foundFirst = false;
            int biggestIndex = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                bool isBigger = IsBiggerThanNeighbours(arr, i);

                if (isBigger)
                {
                    foundFirst = true;
                    biggestIndex = i;
                    break;
                }
            }

            if (foundFirst)
            {
                Console.WriteLine(biggestIndex);
            }
            else
            {
                Console.WriteLine(-1);
            }
        }
    }
}
