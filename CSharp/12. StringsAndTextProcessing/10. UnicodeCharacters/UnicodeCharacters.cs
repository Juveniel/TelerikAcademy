using System;
using System.Text;

namespace _10.UnicodeCharacters
{
    /// <summary>
    /// Write a program that converts a string to a sequence of C# Unicode character literals.
    /// </summary>
    class UnicodeCharacters
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Console.WriteLine(ConvertSringToUnicode(text));
        }

        private static string ConvertSringToUnicode(string text)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in text)
            {
                sb.Append("\\u");
                sb.Append(String.Format("{0:x4}", (int)c));
            }

            return sb.ToString();
        }
    }
}
