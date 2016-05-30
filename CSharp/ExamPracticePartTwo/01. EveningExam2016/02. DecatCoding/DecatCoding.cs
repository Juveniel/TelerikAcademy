using System;
using System.Text;

namespace _02.DecatCoding
{
    class DecatCoding
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ');

            PrintDecodedWords(words);
        }

        private static int ConvertCharToInt(char letter)
        {
            return  char.ToUpper(letter) - 65;
        }

        private static char IntToLetter(int num)
        {
            return Convert.ToChar(num);
        }

        public static long PowerOf21(int digit, int power)
        {
            long result = 1;

            for (int i = 0; i < power; i++)
            {
                result *= 21;
            }

            return result;
        }

        private static string ConvertWordToBase26(string word)
        {  
            StringBuilder sb = new StringBuilder();
            long base21 = 0;

            for(int i = 0; i < word.Length; i++)
            {
                int digit = word[word.Length - 1 - i] - 'a';
                long poweredDigit = PowerOf21(digit, i) * digit;

                base21 += poweredDigit;
            }
        
            while(base21 > 0)
            {
                char symbolToAppend = (char)(base21 % 26 + 'a');
                base21 /= 26;

                sb.Insert(0, symbolToAppend);
            }

            return sb.ToString();
        }

        private static void PrintDecodedWords(string[] words)
        {
            StringBuilder decodedSentence = new StringBuilder();
            for (int i = 0; i < words.Length; i++)
            {
                decodedSentence.Append(ConvertWordToBase26(words[i])).Append(" ");              
            }

            Console.WriteLine(decodedSentence.ToString());
        }
    }
}
