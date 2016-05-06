using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.FrequentNumber
{
    /// <summary>
    /// Write a program that finds the most frequent number 
    /// in an array of N elements.
    /// </summary>
    class FrequentNumber
    {
        static void Main(string[] args)
        {
            int arrLength = int.Parse(Console.ReadLine());
            int[] numArr = new int[arrLength];          

            for(int i = 0; i < arrLength; i++)
            {
                numArr[i] = int.Parse(Console.ReadLine());
            }

            FindMostFrequentNumber(numArr);
        }

        private static void FindMostFrequentNumber(int[] numbers)
        {
            var numbersCollection = new Dictionary<int, int>();
           
            foreach(int num in numbers)
            {
                if (numbersCollection.ContainsKey(num))
                {
                    numbersCollection[num]++;
                }
                else
                {
                    numbersCollection[num] = 1;
                }
            }

            var mostFrequentValueCount = numbersCollection.Values.Max();
            var mostFrequentValue = numbersCollection.FirstOrDefault(x => x.Value == mostFrequentValueCount).Key;

            Console.WriteLine("{0} ({1} times)", mostFrequentValue, mostFrequentValueCount);
        }
      
    }
}
