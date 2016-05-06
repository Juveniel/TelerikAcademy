using System;
using System.Linq;

namespace _03.AppearanceCount
{
    /// <summary>
    /// Write a method that counts how many times given number appears in a given array. 
    /// Write a test program to check if the method is working correctly.
    /// </summary>
    public class AppearanceCount
    {
        internal static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            char[] delimiter = new char[] { ',', ' ' };
            int[] numbersArr = Console.ReadLine().Split(delimiter, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int numToFind = int.Parse(Console.ReadLine());

            Console.WriteLine(CountNumberAppearance(numbersArr, numToFind));
        }

        public static int CountNumberAppearance(int[] arr, int numToFind)
        {
            int counter = 0;
            foreach(int num in arr)
            {
                if(num == numToFind)
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
