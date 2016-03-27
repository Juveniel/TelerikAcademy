using System;

namespace _11.FindBitValue
{
    /// <summary>
    /// We are given number n and position p. Write a sequence of operations
    /// that prints the value of the bit on the position p in the number (0 or 1). 
    /// Example: n=35, p=5 -> 1. Another example: n=35, p=6 -> 0.
    /// </summary>
    class FindBitValue
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int inputNum = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter position of bit: ");
            int bitPosition = int.Parse(Console.ReadLine());

            int mask = inputNum >> bitPosition;
            int bit = 1 & mask;

            Console.WriteLine("Bit value is: {0}", bit);
        }
    }
}
