using System;
using System.Collections.Generic;

namespace _01.SumListSequence
{
    public class SumListSequence
    {
        internal static void Main()
        {
            var numbers = new List<int>();
           
            while (true)
            {
                var input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    break;
                }

                int next;
                var isInteger = int.TryParse(input, out next);            
                if (isInteger)
                {
                    numbers.Add(next);
                }              
            }

            var sum = 0;
            foreach (var value in numbers)
            {
                try
                {
                    sum += value;
                }
                catch (OverflowException)
                {
                    Console.WriteLine($"Overflow occured: {sum}");
                }
            }

            Console.WriteLine($"Sum: {sum} Average: {sum / numbers.Count}");
        }   
    }
}
