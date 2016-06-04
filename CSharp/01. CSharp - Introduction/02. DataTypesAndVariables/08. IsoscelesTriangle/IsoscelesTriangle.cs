using System;
using System.Text;

namespace _08.IsoscelesTriangle
{
    /// <summary>
    /// Write a program that prints an isosceles triangle of 9 copyright symbols ©
    /// </summary>
    class IsoscelesTriangle
    {
        static void Main(string[] args)
        {
            char symbol = '\u00A9';
            Console.OutputEncoding = Encoding.UTF8;

            int symbolsCount = 4;

            int z = 1;
            for (int i = 0; i < symbolsCount; i++)
            {
                if(i != symbolsCount - 1)
                {
                    for (int j = symbolsCount; j > i; j--)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(symbol);

                    if (i != 0)
                    {
                        for (int k = 1; k <= z; k++)
                        {
                            Console.Write(" ");
                        }
                        Console.Write(symbol);
                        z += 2;
                    }
                }
                else
                {
                    for(int k = 0; k < symbolsCount; k++)
                    {
                        Console.Write(" ");
                        Console.Write(symbol);
                    }                                      
                }
                Console.WriteLine();
            }

          



        }      
    }
}
