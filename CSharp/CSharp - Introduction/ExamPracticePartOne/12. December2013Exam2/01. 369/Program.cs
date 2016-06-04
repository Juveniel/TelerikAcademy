using System;
using System.Numerics;

namespace _01._369
{
    class Program
    {
        static void Main(string[] args)
        {
            long a = long.Parse(Console.ReadLine());
            long b = long.Parse(Console.ReadLine());
            long c = long.Parse(Console.ReadLine());

            long r = 0;
            switch (b)
            {
                case 3:
                    r = a + c;
                    break;
                case 6:
                    r = a * c;
                    break;
                case 9:
                    r = a % c;
                    break;
                default:
                    break;
            }

            if(r % 3 == 0)
            {
                Console.WriteLine(r / 3);
            }
            else
            {
                Console.WriteLine(r % 3);
            }

            Console.WriteLine(r);
        }
    }
}
