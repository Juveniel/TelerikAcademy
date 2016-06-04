using System;
using System.Text;

namespace _01.Strings
{
    /// <summary>
    /// Write a program that reads a string, reverses it and prints the result at the console.
    /// </summary>
    class ReverseString
    {
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine();

            Console.WriteLine(ReverseStringText(userInput));
        }

        private static string ReverseStringText(string text)
        {
            StringBuilder sb = new StringBuilder();
            for(int i = text.Length - 1; i >= 0; i--)
            {
                sb.Append(text[i]);
            }

            return sb.ToString();
        }
    }
}
