using System;
using System.Collections.Generic;

namespace _21.LettersCount
{
    /// <summary>
    /// Write a program that reads a string from the console and prints all different letters in
    /// the string along with information how many times each letter is found. 
    /// </summary>
    class LettersCount
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            PrintLetterOccurences(CountLetterOccurences(text));
        }

        static Dictionary<char, int> CountLetterOccurences(string text)
        {
            Dictionary<char, int> letterOccurence = new Dictionary<char, int>();

            for(int i = 0; i < text.Length; i++)
            {
                char currentSymbol = text[i];

                if (Char.IsLetter(currentSymbol))
                {
                    if (letterOccurence.ContainsKey(currentSymbol))
                    {
                        letterOccurence[currentSymbol]++;
                    }
                    else
                    {
                        letterOccurence.Add(currentSymbol, 1);
                    }
                }               
            }

            return letterOccurence;
        }

        static void PrintLetterOccurences(Dictionary<char, int> letterOcc)
        {
            foreach(KeyValuePair<char, int> letter in letterOcc)
            {
                Console.WriteLine("{0} => {1}", letter.Key, letter.Value);
            }
        }
    }
}
