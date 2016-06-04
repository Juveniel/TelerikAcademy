using System;

namespace _13.ModifyBit
{
    /// <summary>
    /// We are given an integer number N, a bit value v and a 
    /// position P. Write a sequence of operators that modifies 
    /// N to hold the value v at the position P from the binary 
    /// representation of N while preserving all other bits in N. 
    /// </summary>
    class ModifyBit
    {
        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());
            int bitPosition = int.Parse(Console.ReadLine());
            int bitChangeVal = int.Parse(Console.ReadLine());

            int mask = 0;
            int newNumber = 0;

            if (bitChangeVal == 1)
            {
                mask = 1 << bitPosition;
                newNumber = inputNum | mask;
            }
            else
            {
                mask = ~(1 << bitPosition);
                newNumber = inputNum & mask;
            }

            Console.WriteLine(newNumber);
        }
    }
}
