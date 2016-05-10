using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _09.ForbiddenWords
{
    /// <summary>
    /// Write a program that replaces the forbidden words with asterisks.
    /// </summary>
    class ForbiddenWords
    {
        static void Main(string[] args)
        {
            string[] forbiddenWords = Console.ReadLine().Split(',');
            string text = Console.ReadLine();

            Console.WriteLine(ReplaceForbiddenWords(text, forbiddenWords));
        }

        static string ReplaceForbiddenWords(string text , string[] forbidden)
        {
            string formattedText = text;                  
            foreach(var forbiddenWord in forbidden)
            {
                formattedText = formattedText.Replace(forbiddenWord, new string('*', forbiddenWord.Trim().Length));                               
            }

            return formattedText;
        }
    }
}
