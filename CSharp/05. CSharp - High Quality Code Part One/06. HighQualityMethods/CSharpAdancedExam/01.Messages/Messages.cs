namespace _01.Messages
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;
    using System.Text;

    public class Messages
    {
        private static readonly Dictionary<string, string> CommunicationCodes = new Dictionary<string, string>()
        {
            { "0", "cad" },
            { "1", "xoz" },
            { "2", "nop" },
            { "3", "cyk" },
            { "4", "min" },
            { "5", "mar" },
            { "6", "kon" },
            { "7", "iva" },
            { "8", "ogi" },
            { "9", "yan" },
        };

        internal static void Main()
        {
            var firstNumber = Console.ReadLine();
            var operation = char.Parse(Console.ReadLine());
            var secondNumber = Console.ReadLine();

            var firstNumDec = ConvertToDecimal(firstNumber);
            var secondNumDec = ConvertToDecimal(secondNumber);

            BigInteger result = 0;
            if (operation.Equals('-'))
            {
                result = BigInteger.Parse(firstNumDec) - BigInteger.Parse(secondNumDec);
            }
            else if (operation.Equals('+'))
            {
                result = BigInteger.Parse(firstNumDec) + BigInteger.Parse(secondNumDec);
            }

            Console.WriteLine(ConvertToGeorgeNumeralSystem(result.ToString()));
        }

        private static string ConvertToDecimal(string number)
        {
            var baseGeorge = new StringBuilder();

            var startIdx = 0;
            while (startIdx < number.Length - 2)
            {
                var wordPart = number.Substring(startIdx, 3);

                if (CommunicationCodes.ContainsValue(wordPart))
                {
                    baseGeorge.Append(CommunicationCodes.First(x => x.Value == wordPart).Key);
                }

                startIdx += 3;
            }

            return baseGeorge.ToString();
        }

        private static string ConvertToGeorgeNumeralSystem(string number)
        {
            var baseGeorge = new StringBuilder(number);

            foreach (var kvp in CommunicationCodes)
            {
                baseGeorge.Replace(kvp.Key, kvp.Value);
            }

            return baseGeorge.ToString();
        }
    }
}
