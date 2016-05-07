using System;
using System.Text;

namespace _06.BinaryToHexadecimal
{
    /// <summary>
    /// Write a program to convert binary numbers to hexadecimal numbers (directly).
    /// </summary>
    class BinaryToHexadecimal
    {
        static void Main(string[] args)
        {
            string inptuNum = Console.ReadLine();

            string result = ConvertBinaryToHex(inptuNum);
            Console.WriteLine(result);
        }

        static string ConvertBinaryToHex(string input)
        {
            StringBuilder result = new StringBuilder(input.Length / 8 + 1);

            int mod4Len = input.Length % 8;
            if (mod4Len != 0)
            {
                input = input.PadLeft(((input.Length / 8) + 1) * 8, '0');
            }

            for (int i = 0; i < input.Length; i += 8)
            {
                string halfByte = input.Substring(i, 8);
                result.AppendFormat("{0:X2}", Convert.ToByte(halfByte, 2));
            }

            return result.ToString();
        }
    }
}
