using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.EncodingSum
{
    class EncodingSum
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();
            char[] inputArr = input.ToCharArray();

            long result = 0;
            var symbol = '\u0040';
            for (int i = 0; i < inputArr.Length; i++)
            {
                char current = inputArr[i];

                if (IsInteger(current))
                {
                    result *= int.Parse(current.ToString());
                }
                else if (IsLetter(current))
                {
                    result += GetLetterIndex(current);
                }
                else if (current == symbol)
                {
                    break;
                }
                else
                {
                    result %= m;
                }
            }

            Console.WriteLine(result);
        }

        static bool IsInteger(char c)
        {
            return Char.IsNumber(c);
        }

        static bool IsLetter(char c)
        {
            return Char.IsLetter(c);
        }

        static int GetLetterIndex(char c)
        {
            int index = char.ToUpper(c) - 64;

            return index - 1;
        }
    }
}
