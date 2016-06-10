namespace _02.GenericList
{
    using System;

    public class Test
    {
        public static void Main()
        {
            GenericList<int> elements = new GenericList<int>();

            // INT COLLECTION TEST
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
            elements.InsertAtPosition(0, 3);
            elements.InsertAtPosition(0, 2);
            elements.InsertAtPosition(0, 1);

            elements.RemoveAtIndex(0);
            elements.RemoveAtIndex(elements.Count - 1);

            Console.WriteLine("\n" + elements);
            Console.WriteLine("Count: {0}", elements.Count);
            Console.WriteLine("Capacity: {0} \n", elements.Capacity);

            // Contains, IndexOf
            Console.WriteLine("Index of element {0}: {1}", 4323, elements.IndexOf(4323));
            Console.WriteLine("Element at index 3 is: {0} \n", elements[3]);

            // Min & Max
            Console.WriteLine("Max value in collection: {0}", elements.Max());
            Console.WriteLine("Min value in collection: {0}", elements.Min());

            // Celar list
            elements.Clear();
            Console.WriteLine("\n" + elements);
            Console.WriteLine("Count: {0}", elements.Count);
            Console.WriteLine("Capacity: {0}", elements.Capacity);

            GenericList<string> elements2 = new GenericList<string>();

            // STRINGS COLLECTION TEST
            Console.WriteLine("\n" + elements2);
            Console.WriteLine("Count: {0}", elements2.Count);
            Console.WriteLine("Capacity: {0}", elements2.Capacity);

            // Auto-grow functionality
            elements2 = new GenericList<string>(3);
            elements2.Add("a");
            elements2.Add("s");
            elements2.Add("d");
            elements2.Add("a");
            elements2.Add("b");  

            Console.WriteLine("\n" + elements2);
            Console.WriteLine("Count: {0}", elements2.Count);
            Console.WriteLine("Capacity: {0}", elements2.Capacity);

            // Min & Max
            Console.WriteLine("Max value in collection: {0}", elements2.Max());
            Console.WriteLine("Min value in collection: {0}", elements2.Min());
        }
    }
}
