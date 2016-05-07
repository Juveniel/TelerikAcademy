using System;
using System.Collections.Generic;

namespace _01.DecimalToBinary
{
    /// <summary>
    /// Write a program to convert decimal numbers to their binary representation.
    /// </summary>
    class DecimalToBinary
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            var binaryRep = ConvertDecimalToBinary(input);

            PrintResult(binaryRep);
        }

        static List<int> ConvertDecimalToBinary(int input)
        {
            var binaryRep = new List<int>();
            while (input > 0)
            {
                if (input == 0)
                {
                    binaryRep.Add(0);
                    break;
                }
                binaryRep.Add((input % 2));
                input /= 2;
            }
            binaryRep.Reverse();

            return binaryRep;
        }

        static void PrintResult(List<int> binary)
        {
            for (int i = 0; i < binary.Count; i++)
            {
                Console.Write("{0}", binary[i]);
            }

            Console.WriteLine();
        }
    }
}
