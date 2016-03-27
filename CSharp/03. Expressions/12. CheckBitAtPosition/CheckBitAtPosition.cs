using System;

namespace _12.CheckBitAtPosition
{
    /// <summary>
    /// Write a Boolean expression that checks if the bit on position p 
    /// in the integer v has the value 1. Example v=5, p=1 -> false.
    /// </summary>
    class CheckBitAtPosition
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int inputNum = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter position of bit: ");
            int bitPosition = int.Parse(Console.ReadLine());

            bool isEqualToOne = false;

            int mask = inputNum >> bitPosition;
            int bit = 1 & mask;

            if(bit == 1)
            {
                isEqualToOne = true;
            }

            Console.WriteLine("Is bit equal to 1: {0}", isEqualToOne);
        }
    }
}
