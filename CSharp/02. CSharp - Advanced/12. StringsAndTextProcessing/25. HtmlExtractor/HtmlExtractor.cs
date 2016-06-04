using System;
using System.Text.RegularExpressions;

namespace _25.HtmlExtractor
{
    /// <summary>
    /// Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags.
    /// </summary>
    class HtmlExtractor
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Match title = Regex.Match(text, "<title>(.*?)</title>");
            Match body = Regex.Match(text, "<body>(.*?)</body>");

            if (title.Success)
            {
                Console.WriteLine("Title: {0}", title.Groups[1].Value.ToString());
            }
            if (body.Success)
            {
                Console.WriteLine("Text: {0}", StripHTML(body.Groups[1].Value.ToString()));
            }
        }

        private static string StripHTML(string input)
        {
            return Regex.Replace(input, "<.*?>", String.Empty);
        }
    }
}
