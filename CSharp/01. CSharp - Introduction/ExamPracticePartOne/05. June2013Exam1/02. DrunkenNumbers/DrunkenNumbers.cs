using System;
using System.Collections.Generic;

namespace _02.DrunkenNumbers
{
    class DrunkenNumbers
    {
        static int vladkosCount = 0;
        static int mitkosCount = 0;

        static void Main(string[] args)
        {         
            int rounds = int.Parse(Console.ReadLine());

            int[] drunkenNumbers = new int[rounds];
            for(int i = 0; i < rounds; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if(i < 0)
                {
                    num *= -1;
                }           
                drunkenNumbers[i] = Math.Abs(num);                                
            }                         

            for(int j = 0; j < drunkenNumbers.Length; j++)
            {
                int currentNum = drunkenNumbers[j];
                int currentNumCount = GetNumberLenth(currentNum);
                int[] currentNumDigits = NumbersIn(currentNum);
                                          
                if (currentNumCount % 2 == 0)
                {
                    for(int k = 0; k < currentNumDigits.Length; k++)
                    {
                        if (k < (currentNumCount / 2))
                        {
                            mitkosCount += currentNumDigits[k];
                        }
                        else
                        {
                            vladkosCount += currentNumDigits[k];
                        }
                    }                                     
                }
                else
                {
                    if(currentNum != 0)
                    {
                        int midDigitIndex = ((currentNumCount / 2) + 1);
                        int midDigit = currentNumDigits[midDigitIndex - 1];

                        vladkosCount += midDigit;
                    }                   

                    for (int l = 0; l < currentNumDigits.Length; l++)
                    {                      
                        if (l <= (currentNumCount / 2))
                        {
                            mitkosCount += currentNumDigits[l];                       
                        }
                        else
                        {                          
                            vladkosCount += currentNumDigits[l];
                        }
                    }                       
                }          
            }

            PrintResult(mitkosCount, vladkosCount);
        }

        static int[] NumbersIn(int value)
        {
            var numbers = new Stack<int>();

            for (; value > 0; value /= 10)
                numbers.Push(value % 10);

            return numbers.ToArray();
        }

        static int GetNumberLenth(int num)
        {
            return num.ToString().Length;
        }

        static void PrintResult(int mitkosCount, int vladkosCount)
        {
            if (mitkosCount > vladkosCount)
            {
                Console.WriteLine("M {0}", mitkosCount - vladkosCount);
            }
            else if (vladkosCount > mitkosCount)
            {
                Console.WriteLine("V {0}", vladkosCount - mitkosCount);
            }
            else
            {
                Console.WriteLine("No {0}", mitkosCount + vladkosCount);
            }
        }
    }
}
