using System;
using System.Numerics;
using System.Collections.Generic;
using System.Text;

namespace KaspichanNumbers
{
    class KaspichanNumbers
    {
        static void Main(string[] args)
        {
            BigInteger number = long.Parse(Console.ReadLine());

            List<string> kaspichanCodes = BuildKaspichanCodeArray();
            string res = DecimalToN(256, number, kaspichanCodes);
            Console.WriteLine(res);
        }

        private static List<string> BuildKaspichanCodeArray()
        {
            List<string> digits = new List<string>();
            for (char digit = 'A'; digit <= 'Z'; digit++)
            {
                digits.Add(digit.ToString());
            }
            for (char prefix = 'a'; prefix <= 'z'; prefix++)
            {
                for (char suffix = 'A'; suffix <= 'Z'; suffix++)
                {
                    digits.Add(String.Format("{0}{1}", prefix.ToString(), suffix.ToString()));
                }
            }
            return digits;
        }

        private static string DecimalToN(long to, BigInteger number, List<string> digits)
        {
            StringBuilder result = new StringBuilder();

            if (number == 0)
            {
                result.Append("A");
                return result.ToString();
            }

            BigInteger remainder;
            while (number > 0)
            {
                remainder = number % to;

                string currentLetter = digits[(int)remainder];
                result.Insert(0, currentLetter);

                number /= to;
            }
           
            return result.ToString();
        }
    }
}
