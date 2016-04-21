using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;

namespace _04.ConsoleApplication1Variant2
{
    class ConsoleApplication1Variant2
    {
        static void Main(string[] args)
        {
            int index = 0;
            BigInteger globalProduct = 1;

            while (true)
            {
                string line = Console.ReadLine();

                if(line == "END")
                {
                    break;
                }

                if(index == 10)
                {
                    Console.WriteLine(globalProduct);
                    globalProduct = 1;
                }

                long num = long.Parse(line);
                if(index % 2 == 1)
                {
                    long product = 1;
                    while (num > 0)
                    {                                        
                        long digit = num % 10;
                        if(digit != 0)
                        {
                            product *= digit;
                        }

                        num /= 10;                       
                    }

                    globalProduct *= product;
                }
                index++;
            }

            Console.WriteLine(globalProduct);
        }
    }
}
