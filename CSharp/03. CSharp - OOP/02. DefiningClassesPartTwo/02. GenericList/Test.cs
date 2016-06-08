namespace _02.GenericList
{
    using System;

    public class Test
    {
        public static void Main()
        {
            GenericList<int> elements = new GenericList<int>();

            // Empty list
            Console.WriteLine("\n" + elements);
            Console.WriteLine("Count: {0}", elements.Count);
            Console.WriteLine("Capacity: {0}", elements.Capacity);

            // Auto-grow functionality
            elements = new GenericList<int>(3);
            elements.Add(1);
            elements.Add(2);
            elements.Add(3);
            elements.Add(4);
            elements.Add(5);
            elements.Add(6);
            elements.Add(7);

            Console.WriteLine("\n" + elements);
            Console.WriteLine("Count: {0}", elements.Count);
            Console.WriteLine("Capacity: {0}", elements.Capacity);

            // Insert, RemoveAt   
            elements.InsertAtPosition(3, 4323);
           // elements.InsertAtPosition(0, 3);
          //  elements.InsertAtPosition(0, 2);
           // elements.InsertAtPosition(0, 1);

            //elements.RemoveAtIndex(0);
           // elements.RemoveAtIndex(elements.Count - 1);

            Console.WriteLine("\n" + elements);
            Console.WriteLine("Count: {0}", elements.Count);
            Console.WriteLine("Capacity: {0}", elements.Capacity);

            // Contains, IndexOf
            Console.WriteLine("\nContain element 2: {0}", elements.GetByIndex(2));
            Console.WriteLine("Index of element 3: {0}", elements.GetByIndex(3));
        }
    }
}
