namespace Exceptions.Utils
{
    using System;
    using System.Collections.Generic;

    public static class MathHelper
    {
        public static T[] Subsequence<T>(T[] arr, int startIndex, int count)
        {
            if (arr == null)
            {
                throw new ArgumentNullException("Arr cannot be null.");
            }

            if (startIndex < 0 || startIndex >= arr.Length)
            {
                throw new IndexOutOfRangeException($"Start index is out of range. Must be between 0 and {arr.Length}");
            }

            if (count < 0)
            {
                throw new ArgumentException("Length of subseqence must be a positive number.");
            }

            var result = new List<T>();
            for (var i = startIndex; i < startIndex + count; i++)
            {
                result.Add(arr[i]);
            }

            return result.ToArray();
        }

        public static bool CheckPrime(int number)
        {                   
            var isPrime = true;

            for (var divisor = 2; divisor <= Math.Sqrt(number); divisor++)
            {
                if (number % divisor == 0)
                {
                    isPrime = false;
                }
            }

            return isPrime;
        }       
    }
}
