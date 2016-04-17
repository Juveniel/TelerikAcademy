using System;
using System.Numerics;

namespace _03.ConsoleApplication1
{
    class ConsoleApplication1
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();

            BigInteger productFirsTen = 1;
            BigInteger productSecondTen = 1;
            BigInteger current;

            int lineCounter = 0;
            while (line != "END")
            {
                if(lineCounter % 2 != 0)
                {
                    current = BigInteger.Parse(line);
                    while (current > 0)
                    {
                        if (current % 10 > 0 && lineCounter <= 9)
                        {
                            productFirsTen *= current % 10;
                        }
                        else if(current % 10 > 0 && lineCounter > 9)
                        {
                            productSecondTen *= current % 10;
                        }
                        current /= 10;
                    }
                }

                lineCounter++;

                line = Console.ReadLine();
            }

            if(lineCounter <= 10)
            {
                Console.WriteLine(productFirsTen);
            }
            else
            {
                Console.WriteLine(productFirsTen);
                Console.WriteLine(productSecondTen);
            }
        }      
    }
}
