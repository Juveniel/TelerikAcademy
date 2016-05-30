using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _08.ExtractSentences
{
    /// <summary>
    /// Write a program that extracts from a given text all sentences containing given word.
    /// </summary>
    class ExtractSentences
    {
        static void Main()
        {
            string text = Console.ReadLine();
            string word = Console.ReadLine();

            Console.WriteLine(ExtractSentencesByWord(text, word));
        }

        private static string ExtractSentencesByWord(string text, string word){
            StringBuilder sb = new StringBuilder();

            char[] delimiters = { '.' };
            string[] sentences = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            for(int i = 0; i < sentences.Length; i++)
            {
                var pattern = "\\b" + word.Trim() + "\\b";

                if (Regex.IsMatch(sentences[i], pattern, RegexOptions.IgnoreCase))
                {
                    sb.Append(sentences[i]).Append('.');
                }
            }

            return sb.ToString();
        }
    }
}
