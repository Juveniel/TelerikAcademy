using System;

namespace _11.LinkedListImplementation
{
    public class Startup
    {
        public static void Main()
        {
            var customLinkedList = new CustomLinkedList<int>();
            customLinkedList.AddFirst(2);
            customLinkedList.RemoveFirst();

            for (var i = 0; i < 10; i++)
            {
                customLinkedList.AddFirst(i);
            }

            customLinkedList.AddLast(123);
            customLinkedList.RemoveFirst();
            customLinkedList.RemoveFirst();

            Console.WriteLine(customLinkedList.Count);

            Console.WriteLine();
        }
    }
}
