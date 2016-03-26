using System;

namespace _12.CheckBitAtPosition
{
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
