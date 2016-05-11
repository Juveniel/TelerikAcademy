using System;

namespace _24.OrderWords
{
    /// <summary>
    /// Write a program that reads a list of words, separated by spaces 
    /// and prints the list in an alphabetical order.
    /// </summary>
    class OrderWords
    {
        static void Main(string[] args)
        {
            string[] wordsList = Console.ReadLine().Split(' ');

            Array.Sort(wordsList, (x, y) => String.Compare(x, y));

            foreach(var str in wordsList)
            {
                Console.WriteLine(str);
            }
        }
    }
}
