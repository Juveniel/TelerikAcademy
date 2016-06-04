using System;
using System.Collections.Generic;

namespace _15.BitSwap
{
    /// <summary>
    /// Write a program first reads 3 numbers n, p, q and k and than swaps bits
    /// {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of n. 
    /// Print the resulting integer on the console.
    /// </summary>
    class BitSwap
    {
        static void Main(string[] args)
        {
            //Receive input
            long inputNum = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int q = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            //Fill dictionary with bits to replace :)
            var bitsDictionary = new Dictionary<int, int>();
            for (byte i = 0; i < k; i++, p++, q++)
            {
                bitsDictionary.Add(p, q);
            }

            //Swap each bit in dictionary
            foreach (KeyValuePair<int, int> entry in bitsDictionary)
            {
                int bitToReplace = entry.Key;
                int replacingBitPos = entry.Value;

                //Find replace bit value       
                long replacingBitVal = 1 & (inputNum >> replacingBitPos);
                long bitToReplaceVal = 1 & (inputNum >> bitToReplace);

                //Replace bits at positions [key]         
                inputNum = ModifyBitAtPosition(inputNum, replacingBitVal, bitToReplace);

                //Replace bits at positions [val]
                inputNum = ModifyBitAtPosition(inputNum, bitToReplaceVal, replacingBitPos);
            }
            Console.WriteLine(inputNum);
        }

        static long ModifyBitAtPosition(long input, long bitVal, int bitPos)
        {
            int mask = 0;
            if (bitVal == 1)
            {
                mask = 1 << bitPos;
                input = input | mask;
            }
            else {
                mask = ~(1 << bitPos);
                input = input & mask;
            }

            return input;
        }
    }
}
