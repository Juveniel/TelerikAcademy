using System;
using System.Collections.Generic;

namespace _07.FindOccuranceInArray
{
    public class FindOccuranceInArray
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

            foreach (var item in occurances)
            {
                Console.WriteLine($"Key: {item.Key}, Count: {item.Value}");
            }
        }
    }
}
