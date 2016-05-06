using System;

namespace _11.ThirdBit
{
    /// <summary>
    /// Using bitwise operators, write a program that uses an expression 
    /// to find the value of the bit at index 3 of an unsigned integer
    /// read from the console.
    /// </summary>
    class ThirdBit
    {
        static void Main(string[] args)
        {
            uint inputNum = uint.Parse(Console.ReadLine());
            int bitPosition = 3;

            uint mask = inputNum >> bitPosition;
            uint bit = 1 & mask;

            if (bit == 1)
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}
