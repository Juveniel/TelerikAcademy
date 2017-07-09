using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.Majorant
{
    public class Majorant
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
        
            int? majorityElement = null;
            int stack = 0;

            foreach (int n in inputList)
            {
                if (stack == 0) majorityElement = n;
                stack += (n == majorityElement) ? 1 : -1;
            }

            int count = inputList.Count(n => n == majorityElement);
            if (!(count > (inputList.Count / 2)))
            {
                Console.WriteLine("No majority element");
            }

            Console.WriteLine(majorityElement);
        }
    }
}
