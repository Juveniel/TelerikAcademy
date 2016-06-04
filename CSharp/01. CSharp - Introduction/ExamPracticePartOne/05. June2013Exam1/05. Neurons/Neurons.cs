using System;

namespace _05.Neurons
{
    class Neurons
    {
        static void Main(string[] args)
        {
            while (true)
            {
                long n = long.Parse(Console.ReadLine());
               
                if(n == -1)
                {
                    break;
                }

                int leftBit = -1;
                int rightBit = -1;

                for (int i = 0; i < 32; i++)
                {
                    long mask = 1 << i;
                    long bit = (n & mask) >> i;

                    if(bit == 1)
                    {
                        if(rightBit == -1)
                        {
                            rightBit = i;
                        }

                        leftBit = i;
                    }
                }

                if(rightBit == -1)
                {
                    Console.WriteLine(0);
                    continue;
                }

                long result = 0;
                for(int k = rightBit; k <= leftBit; k++)
                {
                    long mask = 1 << k;
                    long bit = (n & mask) >> k;

                    if(bit == 0)
                    {
                        result = result | mask;
                    }
                }

                Console.WriteLine(result);
            }             
        }
    }
}
