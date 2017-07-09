using System;
using System.Collections.Generic;

namespace _06.RemoveOddNumberOfOccurances
{
    public class RemoveOddNumberOfOccurances
    {
        public static void Main()
        {
            var inputList = new List<int>();

            while (true)
            {
                var input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    break;
                }

                int nextNumber;
                var isInteger = int.TryParse(input, out nextNumber);

                if (isInteger)
                {
                    inputList.Add(nextNumber);
                }
            }

            Console.WriteLine($"Initial List: { string.Join(",", inputList) }");

            var occurances = new Dictionary<int, int>();
            foreach (var value in inputList)
            {
                var keyExists = occurances.ContainsKey(value);
                if (keyExists)
                {
                    occurances[value]++;
                }
                else
                {
                    occurances.Add(value, 1);
                }
            }

            var result = new List<int>();
            foreach (var item in occurances)
            {
                if (item.Key % 2 != 0)
                {
                    continue;
                }
                for (var i = 0; i < item.Value; i++)
                {
                    result.Add(item.Key);
                }
            }
            Console.WriteLine($"Filtered List: { string.Join(",", result) }");
        }
    }
}
