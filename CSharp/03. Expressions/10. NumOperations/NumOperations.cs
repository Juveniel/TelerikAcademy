using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.NumOperations
{
    /// <summary>
    /// Write a program that takes as input a four-digit number
    /// in format abcd (e.g. 2011) and performs the following actions:
    /// - Calculates the sum of the digits (in our example 2+0+1+1 = 4).
    /// - Prints on the console the number in reversed order: dcba (in our example 1102).
    /// - Puts the last digit in the first position: dabc (in our example 1201).
    /// </summary>
    class NumOperations
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your number: ");
            int inputNum = int.Parse(Console.ReadLine());

            /* Convert input number to array of integers */
            int[] arrDigits = ConvertInputToArray(inputNum);

            /* Print sum of digits */
            PrintArraySum(arrDigits);

            /* Print in reverse order */
            Console.Write("Number in reversed order: ");
            PrintArrayElements(arrDigits.Reverse().ToArray());

            /* Swap first and last digit and print */
            Console.Write("Swapped first and last digit: ");
            PrintArrayElements(SwapArrayValues(arrDigits, 0, arrDigits.Length - 1));

            /* Swap second and third digit and print */
            Console.Write("Swapped second and third digit: ");
            PrintArrayElements(SwapArrayValues(arrDigits, 1, 2));
        }
        
        static int[] ConvertInputToArray(int inputValue)
        {
            var digits = new List<int>();
            for (; inputValue != 0; inputValue /= 10)
                digits.Add(inputValue % 10);

            var arrDigits = digits.ToArray();
            Array.Reverse(arrDigits);

            return arrDigits;
        }

        static void PrintArrayElements(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        static void PrintArraySum(int[] arr)
        {
            int sumOfDigits = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sumOfDigits += arr[i];
            }

            Console.WriteLine("Sum of the digits is: {0}", sumOfDigits);
        }

        static int[] SwapArrayValues(int[] arr, int position1, int position2)
        {
            List<int> modifiedList = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                modifiedList.Add(arr[i]);
            }

            int[] modifiedArr = modifiedList.ToArray();

            int temp = modifiedArr[position1];
            modifiedArr[position1] = modifiedArr[position2];
            modifiedArr[position2] = temp;
                
            return modifiedArr;            
        }
    }
}
