using System;

namespace _16.LongSequence
{
    class LongSequence
    {
        static void Main(string[] args)
        {
            for (int i = 2; i < 1002; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine("-{0}", i);
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
