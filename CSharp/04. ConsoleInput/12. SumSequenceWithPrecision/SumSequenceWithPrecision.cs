using System;

namespace _12.SumSequenceWithPrecision
{
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
