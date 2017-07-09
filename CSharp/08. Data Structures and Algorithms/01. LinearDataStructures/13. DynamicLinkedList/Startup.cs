using System;

namespace _13.DynamicLinkedList
{
    public class Startup
    {
        public static void Main()
        {
            var testQueue = new CustomQueue<int>();

            for (var i = 0; i < 10; i++)
            {
                testQueue.Enqueue(i);
            }

            var teter = testQueue.ToArray();
            testQueue.Clear();
            foreach (var item in teter)
            {
                Console.WriteLine(item);
            }
        }
    }
}
