using System;

namespace _07.ObjectToString
{
    class StringToObject
    {
        static void Main(string[] args)
        {
            string firstText = "Hello";
            string secondText = "World";

            object fullText = firstText + " " + secondText;
            Console.WriteLine(fullText);
        }
    }
}
