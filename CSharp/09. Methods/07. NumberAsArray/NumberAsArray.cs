using System;
using System.Linq;
using System.Numerics;

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
            string[] tokens = Console.ReadLine().Split();
            int firstArrLength = int.Parse(tokens[0]);
            int secondArrLength = int.Parse(tokens[1]);

            char[] delimiter = new char[] { ',', ' ' };
            BigInteger[] firstArr = Console.ReadLine().Split(delimiter, StringSplitOptions.RemoveEmptyEntries).Select(BigInteger.Parse).ToArray();       
            BigInteger[] secondArr = Console.ReadLine().Split(delimiter, StringSplitOptions.RemoveEmptyEntries).Select(BigInteger.Parse).ToArray();

            BigInteger[] sum = SumArrays(firstArr, secondArr);
            PrintArray(sum);
        }

        static BigInteger[] SumArrays(BigInteger[] firstArr, BigInteger[] secondArr)
        {

            int newArrLength = Math.Max(firstArr.Length, secondArr.Length);
            BigInteger[] arr = new BigInteger[newArrLength];

            int next = 0;
            for (int i = 0, j = 0; i < arr.Length; i++, j++)
            {
                BigInteger sum = 0;
                if (firstArr.Length > i) sum += firstArr[i];
                if (secondArr.Length > i) sum += secondArr[i];
                arr[i] = sum % 10 + next;

                if (sum < 10)
                {
                    next = 0;
                }
                else
                {
                    next = 1;
                }
            }

            return arr;
        }

        static void PrintArray(BigInteger[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
