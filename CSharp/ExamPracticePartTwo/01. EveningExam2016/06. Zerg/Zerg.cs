using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06.Zerg
{
    class Zerg
    {
        static Dictionary<string, string> communicationCodes = new Dictionary<string, string> { 
            {"0", "Rawr"},
            {"1", "Rrrr"},
            {"2", "Hsst"},
            {"3", "Ssst"},
            {"4", "Grrr"},
            {"5", "Rarr"},
            {"6", "Mrrr"},
            {"7", "Psst"},
            {"8", "Uaah"},
            {"9", "Uaha"},
            {"A", "Zzzz"},
            {"B", "Bauu"},
            {"C", "Djav"},
            {"D", "Myau"},
            {"E", "Gruh"},
        };
                                   
        static void Main()
        {
            string encodedWord = Console.ReadLine();

            string base15 = ConvertToBase15(encodedWord);
            Console.WriteLine(NToDecimal(base15, 15));
        }

        static string ConvertToBase15(string text)
        {
            var base15 = new StringBuilder();

            int startIdx = 0;
            while(startIdx < text.Length - 3)
            {              
                string wordPart = text.Substring(startIdx, 4);

                if (communicationCodes.ContainsValue(wordPart))
                {
                    base15.Append(communicationCodes.First(x => x.Value == wordPart).Key);
                }

                startIdx += 4;
            }           

            return base15.ToString();
        }


        private static long NToDecimal(string numberToConvert, int from)
        {
            long number = 0;
            byte currentValue;
            numberToConvert = numberToConvert.ToUpper();

            for (int current = 0; current < numberToConvert.Length; current++)
            {
                number *= from;
                if (Char.IsLetter(numberToConvert[current]))
                    currentValue = (byte)(numberToConvert[current] - 55);
                else
                    currentValue = (byte)(numberToConvert[current] - '0');

                number += currentValue;
            }
            return number;
        }
    }
}
