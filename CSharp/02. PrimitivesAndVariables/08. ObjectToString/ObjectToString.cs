using System;

namespace _08.ObjectToString
{
    /// <summary>
    /// Assign string value to an object and cast it to a string.
    /// </summary>
    class ObjectToString
    {
        static void Main(string[] args)
        {
            string firstText = "Hello";
            string secondText = "World";

            object fullText = firstText + " " + secondText;
            string fullTextString = (string)fullText;

            Console.WriteLine(fullTextString);
        }
    }
}
