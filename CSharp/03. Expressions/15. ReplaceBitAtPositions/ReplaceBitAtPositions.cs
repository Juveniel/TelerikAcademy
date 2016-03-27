using System;
using System.Collections.Generic;

namespace _15.ReplaceBitAtPositions
{
    /// <summary>
    ///  Write a program that exchanges the values of the bits 
    ///  on positions 3, 4 and 5 with bits on positions 24, 25 and 26 
    ///  of a given 32-bit unsigned integer.
    /// </summary>
    class ReplaceBitAtPositions
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int inputNum = int.Parse(Console.ReadLine());

            var bitsDictionary = new Dictionary<int, int> { { 2, 24 }, {3, 25}, {4, 27} };
        
            foreach (KeyValuePair<int, int> entry in bitsDictionary)
            {
                int bitToReplace = entry.Key;
                int replacingBitPos = entry.Value;

                //Find replace bit value       
                int replacingBitVal = 1 & (inputNum >> replacingBitPos);

                //Replace bit at this position
                int mask = 0;
                int newNumber = 0;

                if (replacingBitVal == 1)
                {
                    mask = 1 << bitToReplace;
                    newNumber = inputNum | mask;
                }
                else
                {
                    mask = ~(1 << bitToReplace);
                    newNumber = inputNum & mask;
                }

                //Check result
                Console.WriteLine("Bit position to replace: {0}", bitToReplace);
                Console.WriteLine("Bit value to replace with: {0}", replacingBitVal);

                Console.Write("Binary: ");
                Console.WriteLine(Convert.ToString(inputNum, 2).PadLeft(32, '0'));

                Console.Write("Mask:   ");
                Console.WriteLine(Convert.ToString(mask, 2).PadLeft(32, '0'));

                Console.Write("Result: ");
                Console.WriteLine(Convert.ToString(newNumber, 2).PadLeft(32, '0'));
           
                Console.WriteLine("=====================================================================");
            }


        }
    }
}
