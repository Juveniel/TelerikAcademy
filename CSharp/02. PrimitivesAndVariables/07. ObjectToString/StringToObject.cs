using System;

namespace _07.ObjectToString
{
    /// <summary>
    /// Declare two variables of type string.
    /// Assing the value from concatenation of the two strings to an object.
    /// Print the result.
    /// </summary>
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
