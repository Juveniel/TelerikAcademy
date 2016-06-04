using System;
using System.Text.RegularExpressions;

namespace _20.Palindromes
{
    /// <summary>
    /// Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.
    /// </summary>
    class Palindromes
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            MatchCollection words = Regex.Matches(text, @"\b\w+\b");

            foreach (var word in words)
            {
                if (IsPalindrome(word.ToString()))
                {
                    Console.WriteLine(word);
                }
            }              
            Console.WriteLine();
        }

        private static bool IsPalindrome(string value)
        {
            int min = 0;
            int max = value.Length - 1;
            while (true)
            {
                if (min > max)
                {
                    return true;
                }
                char a = value[min];
                char b = value[max];

                // Scan forward for a while invalid.
                while (!char.IsLetterOrDigit(a))
                {
                    min++;
                    if (min > max)
                    {
                        return true;
                    }
                    a = value[min];
                }

                // Scan backward for b while invalid.
                while (!char.IsLetterOrDigit(b))
                {
                    max--;
                    if (min > max)
                    {
                        return true;
                    }
                    b = value[max];
                }

                if (char.ToLower(a) != char.ToLower(b))
                {
                    return false;
                }
                min++;
                max--;
            }
        }
    }
}
