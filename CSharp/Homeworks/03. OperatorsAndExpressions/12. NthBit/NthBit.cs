using System;

namespace _12.NthBit
{
    /// <summary>
    /// Write a program that reads from the console two integer numbers
    /// P and N and prints on the console the value of P's N-th bit. 
    /// </summary>
    class NthBit
    {
        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());
            int bitPosition = int.Parse(Console.ReadLine());

            bool isEqualToOne = false;

            int mask = inputNum >> bitPosition;
            int bit = 1 & mask;

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
