using System;

namespace _02.Decoding
{
    class Decoding
    {
        static void Main(string[] args)
        {
            int salt = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            char[] inputArr = input.ToCharArray();
        
            var symbol = '\u0040';
            for (int i = 0; i < inputArr.Length; i++)
            {
                char current = inputArr[i]; 
                decimal result = 0;
                int code = current;

                if (IsInteger(current))
                {
                    result = code + salt + 500;
                }
                else if (IsLetter(current))
                {        
                    result = (code * salt) + 1000;
                }
                else if (current == symbol)
                {
                    break;
                }
                else
                {
                    result = code - salt;
                }

                string resultFormatted = "";
                if(i % 2 == 0)
                {
                    result /= 100M;
                    resultFormatted = string.Format("{0:F2}", result);       
                }
                else if(i % 2 != 0)
                {
                    result *= 100M;
                    resultFormatted = string.Format("{0}", result);
                }

                Console.WriteLine(resultFormatted);
            }

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
