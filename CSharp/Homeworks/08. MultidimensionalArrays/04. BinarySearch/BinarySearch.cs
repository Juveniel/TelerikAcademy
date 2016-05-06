using System;

namespace _04.BinarySearch
{
    /// <summary>
    /// Write a program, that reads from the console an array of N integers and an integer K, 
    /// sorts the array and using the method Array.BinSearch() finds the largest number in 
    /// the array which is ≤ K.
    /// </summary>
    class BinarySearch
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            int[] numbersArr = new int[n];
            for (int i = 0; i < numbersArr.Length; i++)
            {
                numbersArr[i] = int.Parse(Console.ReadLine());
            }

            int index = Array.BinarySearch(numbersArr, k);

            if (index >= 0)
            {
                Console.WriteLine(numbersArr[index]);
            }
            else
            {
                Console.WriteLine(numbersArr[index - 1]);
            }         
        }
    }
}
