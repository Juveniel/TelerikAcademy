using System;
using System.Linq;

namespace _05.HexadecimalToBinary
{
    /// <summary>
    /// Write a program to convert hexadecimal numbers to binary numbers (directly).
    /// </summary>
    class HexadecimalToBinary
    {
        static void Main(string[] args)
        {
            string hexNum = Console.ReadLine();
            string binaryRep = HexToBinary(hexNum);

            Console.WriteLine(binaryRep);        
        }

        static string HexToBinary(string inputNum)
        {
            string binarystring = String.Join(String.Empty,
                inputNum.Select(
                c => Convert.ToString(Convert.ToInt32(c.ToString(), 16), 2).PadLeft(4, '0')
                )
            ).TrimStart('0');

            return binarystring;
        }
    }
}
