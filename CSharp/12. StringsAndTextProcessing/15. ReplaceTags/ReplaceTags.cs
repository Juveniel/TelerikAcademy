using System;
using System.Text.RegularExpressions;

namespace _15.ReplaceTags
{
    class ReplaceTags
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
      
            Console.WriteLine(ReplaceAllAnchors(text));
        }

        static string ReplaceAllAnchors(string text)
        {
            string result = String.Empty;

            var regEx = new Regex("<a href=\"(.*?)\">(.*?)</a>");
            result = regEx.Replace(text, m => "[" + m.Groups[2].Value + "]" + "(" + m.Groups[1].Value + ")");

            return result;
        }
    }
}
