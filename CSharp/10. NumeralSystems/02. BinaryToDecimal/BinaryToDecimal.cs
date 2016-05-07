using System;
using System.Collections.Generic;

namespace _02.BinaryToDecimal
{
    /// <summary>
    /// Write a program to convert binary numbers to their decimal representation.
    /// </summary>
    class BinaryToDecimal
    {
        static void Main(string[] args)
        {
            string binaryNum = Console.ReadLine();

            int decimalRep = ConvertBinaryToDecimal(binaryNum);

            Console.WriteLine(decimalRep);
        }

        static int ConvertBinaryToDecimal(string num)
        {
            int decimalRep = 0;
            for (int i = 0; i < num.Length; i++)
            {
                decimalRep = decimalRep << 1;
                if (num[i] == '1')
                {
                    decimalRep = decimalRep ^ 1;
                }
            }

            return decimalRep;
        }


    }
}
