using System;
using System.Text;

namespace _07.EncodeDecodeString
{
    /// <summary>
    /// Write a program that encodes and decodes a string using given encryption key (cipher).
    /// </summary>
    class EncodeDecodeString
    {
        static void Main(string[] args)
        {
            string cifer = Console.ReadLine();
            string text = Console.ReadLine();

            string encoded = EncodeOrDecodeText(text, cifer);
            string decoded = EncodeOrDecodeText(encoded, cifer);

            Console.WriteLine("Encoded string: {0}", encoded);
            Console.WriteLine("Decoded string: {0}", decoded);
        }

        static string EncodeOrDecodeText(string text, string cifer)
        {
            StringBuilder result = new StringBuilder();

            for (int c = 0; c < text.Length; c++)
            {
                result.Append((char)((uint)text[c] ^ (uint)cifer[c % cifer.Length]));
            }

            return result.ToString();
        }
    }
}
