using System;
using System.Text.RegularExpressions;

namespace _18.Extract_e_mails
{
    class ExtractEmails
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            PrintFoundEmails(text);
        }

        private static void PrintFoundEmails(string text)
        {
            MatchCollection emails = Regex.Matches(text, @"([\w-\.]+)@((?:[\w]+\.)+)([a-zA-Z]{2,4})");
            foreach (var email in emails)
            {
                Console.WriteLine(email);
            }
        }
    }
}
