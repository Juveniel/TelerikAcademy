using System;
using System.Collections.Generic;

namespace _04.LongestSubsequence
{
    public class LongestSubsequence
    {
        public static void Main()
        {
            var inputList = new List<int>();
            while (true)
            {
                var nextLine = Console.ReadLine();
                if (string.IsNullOrEmpty(nextLine))
                {
                    break;
                }

                int next;
                var isInteger = int.TryParse(nextLine, out next);
                if (isInteger)
                {
                    inputList.Add(next);
                }
            }

            var maxSequence = new List<int>();
            var tempSequence = new List<int>();

            for (var i = 1; i < inputList.Count; i++)
            {
                if (inputList[i] == inputList[i - 1])
                {
                    tempSequence.Add(inputList[i]);
                }
                else
                {
                    if (maxSequence.Count < tempSequence.Count)
                    {
                        maxSequence = new List<int>(tempSequence);
                    }

                    tempSequence = new List<int> {inputList[i]};
                }               
            }

            Console.WriteLine(string.Join(", ", maxSequence));
        }
    }
}
