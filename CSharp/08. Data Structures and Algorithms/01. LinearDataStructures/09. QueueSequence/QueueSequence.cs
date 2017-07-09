using System;
using System.Collections.Generic;

namespace _09.QueueSequence
{
    public class QueueSequence
    {
        public static void Main()
        {
            var results = new List<int>();

            var numbers = new Queue<int>();

            numbers.Enqueue(2);

            for (var i = 0; i < 50; i++)
            {
                var s = numbers.Dequeue();

                results.Add(s);

                numbers.Enqueue(s + 1);
                numbers.Enqueue(2 * s + 1);
                numbers.Enqueue(s + 2);
            }

            Console.WriteLine(string.Join(" ", results));
        }
    }
}
