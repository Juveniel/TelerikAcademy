using System;
using System.Numerics;

namespace _03.ConsoleApplication2
{
    class ConsoleApplication2
    {
        static void Main(string[] args)
        {
            BigInteger globalProductFirstTen = 1;
            BigInteger globalProductSecondTen = 1;
            int positionCounter = 0;

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "END")
                {
                    break;
                }
               
                if(positionCounter % 2 == 0)
                {
                    BigInteger product = 1;
                    for (int i = 0; i < line.Length; i++)
                    {
                        BigInteger currentNum = BigInteger.Parse(line[i].ToString());

                        if (currentNum != 0)
                        {
                            product *= currentNum;
                        }                                        
                    }

                    if(positionCounter < 10)
                    {
                        globalProductFirstTen *= product;
                    }
                    else
                    {
                        globalProductSecondTen *= product;
                    }                             
                }

                positionCounter++;
            }
                     
            if (positionCounter > 10)
            {
                Console.WriteLine(globalProductFirstTen);
                Console.WriteLine(globalProductSecondTen);
            }
            else
            {
                Console.WriteLine(globalProductFirstTen);
            }
        }
    }
}
