using System;

namespace _09.PrintSequence
{
    class PrintSequence
    {
        static void Main(string[] args)
        {
            for(int i = 2; i < 12; i++)
            {
                if(i % 2 != 0)
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
