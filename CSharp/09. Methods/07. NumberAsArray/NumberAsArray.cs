using System;
using System.Linq;

namespace _07.NumberAsArray
{
    /// <summary>
    /// Write a method that adds two positive integer numbers represented as arrays of digits 
    /// (each array element arr[i] contains a digit; the last digit is kept in arr[0]).
    /// Write a program that reads two arrays representing positive integers and outputs their sum.
    /// </summary>
    class NumberAsArray
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split(' ');
            int firstArrLength = int.Parse(tokens[0]);
            int secondArrLength = int.Parse(tokens[1]);

            char[] delimiter = new char[] { ' ' };
            int[] firstArr = Console.ReadLine().Split(delimiter, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] secondArr = Console.ReadLine().Split(delimiter, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            SumArrays(firstArr, secondArr);
        }

        static void SumArrays(int[] firstArr, int[] secondArr)
        {
            int neededLength = 0;
            if (firstArr.Length > secondArr.Length)
            {
                neededLength = firstArr.Length;
            }
            else
            {
                neededLength = secondArr.Length;
            }

            int[] newNumber = new int[neededLength];
            for (int i = 0; i < newNumber.Length; i++)
            {
                if (i < firstArr.Length)
                {
                    newNumber[i] = newNumber[i] + firstArr[i];
                    if (newNumber[i] >= 10)
                    {
                        newNumber[i] = newNumber[i] - 10;
                        newNumber[i + 1] = newNumber[i + 1] + 1;
                    }
                }

                if (i < secondArr.Length)
                {
                    newNumber[i] = newNumber[i] + secondArr[i];
                    if (newNumber[i] >= 10)
                    {
                        newNumber[i] = newNumber[i] - 10;
                        newNumber[i + 1] = newNumber[i + 1] + 1;
                    }
                }
            }

            for (int i = 0; i < newNumber.Length; i++)
            {
                Console.Write(newNumber[i] + " ");
            }

            Console.WriteLine();
        }

        static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
