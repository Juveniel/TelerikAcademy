using System;

namespace _12.SumSequenceWithPrecision
{
    /// <summary>
    /// Write a program that calculates the sum (with precision of 0.001) 
    /// of the following sequence: 1 + 1/2 - 1/3 + 1/4 - 1/5 + …
    /// </summary>
    class SumSequenceWithPrecision
    {
        static void Main(string[] args)
        {
            decimal sum = 1m;
            int i = 1;
            while (i < 1000)
            {
                i++;

                if ((i & 1) == 1)
                {
                    sum -= 1m / i;
                }
                else
                {
                    sum += 1m / i;
                }                            
            }
            Console.WriteLine(Math.Round(sum, 3));
        }
    }
}
