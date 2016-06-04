using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SymbolToNumber
{
    class SymbolToNumber
    {
        static void Main(string[] args)
        {
            int secret = int.Parse(Console.ReadLine());
            string inputText = Console.ReadLine();

            for(int i = 0; i < inputText.Length; i++)
            {
                decimal result = 0;
                char current = inputText[i];
                int code = (int)current;

                if(current == '@')
                {
                    break;
                }
                else if (Char.IsLetter(current))
                {
                    result = code * secret + 1000M;
                }
                else if (Char.IsDigit(current))
                {
                    result = code + secret + 500M;
                }
                else
                {
                    result = code - secret;
                }

                if(i % 2 == 0)
                {
                    result /= 100;
                    result = decimal.Parse(String.Format("{0:00.00}", result));
                }
                else
                {
                    result *= 100;
                }

                Console.WriteLine(result);
            }   
        }
    }
}
