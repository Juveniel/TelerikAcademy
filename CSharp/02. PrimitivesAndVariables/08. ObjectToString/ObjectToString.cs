using System;

namespace _08.ObjectToString
{
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
