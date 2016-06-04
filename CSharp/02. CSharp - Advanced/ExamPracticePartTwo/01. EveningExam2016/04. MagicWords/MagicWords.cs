using System;
using System.Collections.Generic;
using System.Text;

namespace _04.MagicWords
{
    class MagicWords
    {
        static void Main(string[] args)
        {
            int numberOfWords = int.Parse(Console.ReadLine());

            var wordsList = FillListWithInput(numberOfWords);
            ReorderList(wordsList);

            PrintMagicWord(wordsList);          
        }

        private static List<string> FillListWithInput(int wordsCount)
        {
            List<string> words = new List<string>();
            for (int i = 0; i < wordsCount; i++)
            {
                words.Add(Console.ReadLine());
            }

            return words;
        }

        private static void ReorderList(List<string> words)
        {
            for (int i = 0; i < words.Count; i++)
            {
                string currentWord = words[i];
                int newWordIdx = currentWord.Length % (words.Count + 1);

                words.Insert(newWordIdx, currentWord);

                if (newWordIdx < i)
                {
                    words.RemoveAt(i + 1);
                }
                else
                {
                    words.RemoveAt(i);
                }
            }
        }

        private static void PrintMagicWord(List<string> reorderedList)
        {
            StringBuilder magicWord = new StringBuilder();
            var maxLength = 0;

            foreach (var word in reorderedList)
            {
                maxLength = Math.Max(maxLength, word.Length);
            }
            
            for (int i = 0; i < maxLength; i++)
            {
                foreach (var word in reorderedList)
                {
                    if (word.Length > i)
                    {
                        magicWord.Append(word[i]);
                    }
                }
            }

            Console.WriteLine(magicWord.ToString());
        }
    }
}
