using System;
using System.Text;

namespace _08.ShortToBinary
{
    /// <summary>
    /// Write a program that shows the binary representation of given 16-bit signed integer number N
    /// </summary>
    class ShortToBinary
    {
        static void Main(string[] args)
        {
            short numToConvert = short.Parse(Console.ReadLine());

            Console.WriteLine(ShortToBinary(numToConvert));
        }

        private static string ShortToBinary(short number)
        {
            if (number == 0)
                return new String('0', 16);

            StringBuilder binary = new StringBuilder();

            for (int bit = 0; bit < 16; bit++)
            {
                binary.Insert(0, (number >> bit) & 1);
            }

            return binary.ToString();
        }
    }
}
