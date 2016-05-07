using System;

namespace _02.RandomNumbers
{
    /// <summary>
    /// Write a program that generates and prints to the console 
    /// 10 random values in the range [100, 200].
    /// </summary>
    class RandomNumbers
    {
        static void Main()
        {
            PrintTenRandomNumbers();
        }

        static void PrintTenRandomNumbers()
        {
            Random rand = new Random();
            for(int i = 0; i < 10; i++)
            {
                Console.Write("{0} ", rand.Next(100, 200));
            }
            Console.WriteLine();
        }
    }
}
