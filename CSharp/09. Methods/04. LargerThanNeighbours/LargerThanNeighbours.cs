using System;
using System.Linq;

namespace _04.LargerThanNeighbours
{
    /// <summary>
    /// Write a method that checks if the element at given position in given array of integers
    /// is larger than its two neighbours (when such exist). Write program that reads an array 
    /// of numbers and prints how many of them are larger than their neighbours.
    /// </summary>
    class LargerThanNeighbours
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[] delimiter = new char[] { ',', ' ' };
            int[] numbersArr = Console.ReadLine().Split(delimiter, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int counter = 0;
            for (int i = 0; i < numbersArr.Length; i++)
            {
                bool isBigger = IsBiggerThanNeighbours(numbersArr, i);

                if (isBigger)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);     
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
    }
}
