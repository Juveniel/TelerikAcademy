using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.PrintTriangle
{
    class PrintTriangle
    {
        static void Main(string[] args)
        {
            char symbol = '\u00A9';
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Enter height: ");
            int iterationsCount = int.Parse(Console.ReadLine());

            for (int i = iterationsCount; i > 0; i--)
            {            
                Console.Write(new string(' ', i));             
                Console.Write(symbol);
                     
                for (int j = iterationsCount  ; j > i; j--)
                {                
                    Console.Write(' ');
                  
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }          
        }
    }
}
