using System;
using System.Collections.Generic;
using System.Text;

namespace _05.StrangelandNumbers
{
    class StrangelandNumbers
    {

        static Dictionary<string, string> codes = new Dictionary<string, string>()
        {
            { "0", "f" },
            { "1", "bIN" },
            { "2", "oBJEC" },
            { "3", "mNTRAVL" },
            { "4", "lPVKNQ" },
            { "5", "pNWE" },
            { "6", "hT" }
        };

        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            string messageInStrangeland = ConvertToStrangelandSystem(message);

            Console.WriteLine(NToDecimal(messageInStrangeland, 7));
        }

        static string ConvertToStrangelandSystem(string message)
        {
            var decoded = new StringBuilder(message);

            foreach (var kvp in codes)
            {
                decoded.Replace(kvp.Value, kvp.Key);
            }
                                              
            return decoded.ToString();
        }

        static long NToDecimal(string numberToConvert, long from)
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
