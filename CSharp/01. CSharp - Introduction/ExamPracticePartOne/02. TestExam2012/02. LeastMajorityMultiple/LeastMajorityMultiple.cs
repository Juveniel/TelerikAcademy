using System;
using System.Linq;

namespace _02.LeastMajorityMultiple
{
    class LeastMajorityMultiple
    {
        static void Main(string[] args)
        {

            long[] inputList = new long[5];
            for(int i = 0; i < 5; i++)
            {
                inputList[i] = long.Parse(Console.ReadLine());
            }

            Console.WriteLine(LCM(inputList));
        }

        static long LCM(long[] numbers)
        {
            return numbers.Aggregate(lcm);
        }
        static long lcm(long a, long b)
        {
            return Math.Abs(a * b) / GCD(a, b);
        }
        static long GCD(long a, long b)
        {
            return b == 0 ? a : GCD(b, a % b);
        }
    }
}
