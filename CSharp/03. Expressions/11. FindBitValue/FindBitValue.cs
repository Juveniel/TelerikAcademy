using System;

namespace _11.FindBitValue
{
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
