using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.MultiverseCommunication
{
    class Program
    {
        private static Dictionary<string, string> codes = new Dictionary<string, string>()
        {
            { "0", "CHU" },
            { "1", "TEL" },
            { "2", "OFT" },
            { "3", "IVA" },
            { "4", "EMY" },
            { "5", "VNB" },
            { "6", "POQ" },
            { "7", "ERI" },
            { "8", "CAD" },
            { "9", "K-A" },
            { "A", "IIA" },
            { "B", "YLO" },
            { "C", "PLA" }
        };

        static void Main(string[] args)
        {                                            
            string input = Console.ReadLine();

            string numericMessage = GetEncryptedNumericMessage(input);

            Console.WriteLine(NToDecimal(numericMessage, 13));
        }

        private static string GetEncryptedNumericMessage(string input)
        {
            StringBuilder message = new StringBuilder();

            int startIdx = 0;
            while (startIdx < input.Length - 2)
            {
                string part = input.Substring(startIdx, 3);

                if (codes.ContainsValue(part))
                {
                    startIdx += 3;
                    message.Append(codes.FirstOrDefault(x => x.Value == part).Key);
                }
            }

            return message.ToString();
        }       

        private static long NToDecimal(string numberToConvert, long from)
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
