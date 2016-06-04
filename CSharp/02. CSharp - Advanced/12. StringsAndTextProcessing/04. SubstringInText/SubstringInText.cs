using System;

namespace _04.SubstringInText
{
    /// <summary>
    /// Write a program that finds how many times a sub-string is contained
    /// in a given text (perform case insensitive search).
    /// </summary>
    class SubstringInText
    {
        static void Main(string[] args)
        {
            string wordToFind = Console.ReadLine();
            string text = Console.ReadLine();         

            Console.WriteLine(CountAppearanceInText(text, wordToFind));
        }

        static int CountAppearanceInText(string text, string wordToFind)
        {
            int appearanceCounter = 0;
 
            for (int i = 0; i < text.Length - wordToFind.Length + 1; i++)
            {
                if (text.Substring(i, wordToFind.Length).Equals(wordToFind, StringComparison.OrdinalIgnoreCase))
                    appearanceCounter++;
            }

            return appearanceCounter;
        }
    }    
}
