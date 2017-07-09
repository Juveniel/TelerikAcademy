using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.RemoveNegativeNumbers
{
    public class RemoveNegativeNumbers
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

            inputList = inputList.Where(x => x >= 0).ToList();
            Console.WriteLine($"Filtered List: { string.Join(",", inputList) }");
        }
    }
}
