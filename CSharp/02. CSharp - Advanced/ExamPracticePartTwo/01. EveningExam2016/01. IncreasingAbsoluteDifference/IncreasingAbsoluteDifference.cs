using System;
using System.Collections.Generic;

namespace _01.IncreasingAbsoluteDifference
{
    class IncreasingAbsoluteDifference
    {
        static void Main(string[] args)
        {
            int numOfLines = int.Parse(Console.ReadLine());

            List<string> sequencesResult = new List<string>();
            for (int i = 0; i < numOfLines; i++)
            {
                string[] lineDigits = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);       
                sequencesResult.Add(CheckIncreasingSequence(lineDigits).ToString());    
            }

            PrintArr(sequencesResult);

        }

        static bool CheckIncreasingSequence(string[] numbers)
        {
            bool isIncreasing = false;
            int increasingSeqCounter = 1;

            List<int> sequence = new List<int>();
            for(int i = 0; i < numbers.Length - 1; i++)
            {              
                int currentElement = int.Parse(numbers[i]);
                int nextElement = int.Parse(numbers[i + 1]);

                int currAbs = Math.Abs(nextElement - currentElement);
                sequence.Add(currAbs);       
            }
            
            for (int j = 0; j < sequence.Count - 1; j++)
            {
               if(sequence[j] <= sequence[j + 1] && (sequence[j + 1] - sequence[j] <= 1))
                {
                    increasingSeqCounter++;
                }                                                                                                       
            }

            if(increasingSeqCounter == numbers.Length - 1)
            {
                isIncreasing = true;
            }

            return isIncreasing;
        }

        static void PrintArr(List<string> result)
        {
            foreach (var digit in result)
            {
                Console.WriteLine(digit);
            }
        }
    }
}
