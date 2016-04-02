using System;
using System.Collections.Generic;

namespace _14.BitExchange
{
    class BitExchange
    {
        static void Main(string[] args)
        {
            long inputNum = int.Parse(Console.ReadLine());

            var bitsDictionary = new Dictionary<int, int> { { 3, 24 }, { 4, 25 }, { 5, 26 } };

            foreach (KeyValuePair<int, int> entry in bitsDictionary)
            {
                int bitToReplace = entry.Key;
                int replacingBitPos = entry.Value;

                //Find replace bit value       
                long replacingBitVal = 1 & (inputNum >> replacingBitPos);
                long bitToReplaceVal = 1 & (inputNum >> bitToReplace);

                //Replace bits at positions 3,4,5
                int mask = 0;                                          
                if (replacingBitVal == 1)
                {
                    mask = 1 << bitToReplace;
                    inputNum = inputNum | mask;                   
                }
                else
                {
                    mask = ~(1 << bitToReplace);
                    inputNum = inputNum & mask;                   
                }

                //Replace bits at positions 24,25,26
                int maskLarge = 0;
                if (bitToReplaceVal == 1)
                {
                    maskLarge = 1 << replacingBitPos;
                    inputNum = inputNum | maskLarge;
                }
                else
                {
                    maskLarge = ~(1 << replacingBitPos);
                    inputNum = inputNum & maskLarge;
                }
            }
              Console.WriteLine(inputNum);
        }    
    }
}
