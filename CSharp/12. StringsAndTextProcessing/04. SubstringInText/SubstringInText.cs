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
            int startingIndex = 0;       

            while((startingIndex = text.IndexOf(wordToFind, startingIndex)) != -1)
            { 
                appearanceCounter++;
                startingIndex += wordToFind.Length;
            }

            return appearanceCounter;
        }
    }
}
