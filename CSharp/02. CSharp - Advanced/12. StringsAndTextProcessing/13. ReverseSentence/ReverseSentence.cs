using System;
using System.Linq;
using System.Text;

namespace _13.ReverseSentence
{
    /// <summary>
    /// Write a program that reverses the words in given sentence.
    /// </summary>
    class ReverseSentence
    {
        static void Main(string[] args)
        {
            string sentence = Console.ReadLine();
            string reversed = ReverseSentenceWords(sentence);

            Console.WriteLine(reversed);
        }

        private static string ReverseSentenceWords(string sentence)
        {
            StringBuilder sb = new StringBuilder();
            string[] split = sentence.Split(' ');
            for (int i = split.Length - 1; i > -1; i--)
            {
                sb.Append(split[i]);
                sb.Append(" ");
            }

            return sb.ToString();
        }
    }
}
