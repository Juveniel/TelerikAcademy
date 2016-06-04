using System;
using System.Collections.Generic;

namespace _22.WordsCount
{
    /// <summary>
    /// Write a program that reads a string from the console and lists all
    /// different words in the string along with information how many times each word is found.
    /// </summary>
    class WordsCount
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            PrintWordsOccurences(CountWordsOccurences(text));
        }

        static Dictionary<string, int> CountWordsOccurences(string text)
        {
            Dictionary<string, int> wordOccurence = new Dictionary<string, int>();
            string[] words = text.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                string currentWord = words[i];
               
                if (wordOccurence.ContainsKey(currentWord))
                {
                    wordOccurence[currentWord]++;
                }
                else
                {
                    wordOccurence.Add(currentWord, 1);
                }                
            }

            return wordOccurence;
        }

        static void PrintWordsOccurences(Dictionary<string, int> letterOcc)
        {
            foreach (KeyValuePair<string, int> letter in letterOcc)
            {
                Console.WriteLine("{0} => {1}", letter.Key, letter.Value);
            }
        }
    }
}
