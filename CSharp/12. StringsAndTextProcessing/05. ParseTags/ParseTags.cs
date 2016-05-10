using System;
using System.Text.RegularExpressions;

namespace _05.ParseTags
{
    /// <summary>
    /// You are given a text. Write a program that changes the text in all 
    /// regions surrounded by the tags <upcase> and </upcase> to upper-case.
    /// </summary>
    class ParseTags
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();           
          
            Console.WriteLine(ReplaceAllOccurences(text));
        }

        static string ReplaceAllOccurences(string text)
        {
            string result = String.Empty;

            var regEx = new Regex("<upcase>(.*?)</upcase>");
            result = regEx.Replace(text, m => m.Groups[1].Value.ToUpper());

            return result;
        }
    }
}
