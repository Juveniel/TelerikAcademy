using System;

namespace _03.DecimalToHexadecimal
{
    /// <summary>
    /// Write a program to convert decimal numbers to their hexadecimal representation.
    /// </summary>
    class DecimalToHexadecimal
    {
        static void Main(string[] args)
        {
            long num = long.Parse(Console.ReadLine());
            string numHex = ConvertDecimalToHex(num);

            Console.WriteLine(numHex);
        }

        static string ConvertDecimalToHex(long num)
        {
            string result = "";

            while (num != 0)
            {
                if ((num % 16) < 10)
                    result = num % 16 + result;
                else
                {
                    string temp = "";

                    switch (num % 16)
                    {
                        case 10: temp = "A"; break;
                        case 11: temp = "B"; break;
                        case 12: temp = "C"; break;
                        case 13: temp = "D"; break;
                        case 14: temp = "E"; break;
                        case 15: temp = "F"; break;
                    }

                    result = temp + result;
                }

                num /= 16;
            }

            return result;
        }
    }
}
