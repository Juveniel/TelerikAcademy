using System;

namespace _12.LetterIndex
{
    /// <summary>
    /// Write a program that creates an array containing all letters from the
    /// alphabet (a-z). Read a word from the console and print the index 
    /// of each of its letters in the array.
    /// </summary>
    class LetterIndex
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
                        
            for(int i = 0; i < word.Length; i++)
            {
                Console.WriteLine(GetLetterIndex(alphabet, word[i].ToString().ToLower()));              
            }       
        }

        private static int GetLetterIndex(string alphabet, string letter)
        {
            return  alphabet.IndexOf(letter);
        }
    }
}
