using System;

namespace _05.SortByStrLength
{
    /// <summary>
    /// You are given an array of strings. Write a method that sorts 
    /// the array by the length of its elements
    /// </summary>
    class SortByStrLength
    {
        static void Main(string[] args)
        {
            string[] unsortedArr = { "ba", "babababa", "afdafdafdfad", "a2", "1235df", "wdasdwe" };

            Array.Sort(unsortedArr, (x, y) => x.Length.CompareTo(y.Length));
            foreach (string s in unsortedArr)
            {
                Console.WriteLine(s);
            }
        }
    }
}
