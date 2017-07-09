using System;
using System.Collections.Generic;

namespace _02.ReverseIntegers
{
    public class ReverseIntegers
    {
        public static void Main()
        {
            var stacks = new Stack<int>();

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
                    stacks.Push(next);
                }
            }
                  
            var outputList = new List<int>();
            while (stacks.Count > 0)
            {
                outputList.Add(stacks.Pop());
            }

            outputList.ForEach(i => Console.Write("{0}, ", i));
        }
    }
}
