using System;

namespace _12.StackImplementation
{
    public class Startup
    {
        public static void Main()
        {
            var myStack = new CustomStack<int>();          

            for (var i = 0; i < 10; i++)
            {
                myStack.Push(i);
            }

            var copy = myStack.ToArray();
            foreach (var t in copy)
            {
                Console.WriteLine(t);
            }
        }
    }
}
