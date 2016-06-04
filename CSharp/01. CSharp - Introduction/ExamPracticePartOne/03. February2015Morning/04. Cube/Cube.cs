using System;

namespace _04.Cube
{
    class Cube
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(new string(' ', n - 1) + new string(':', n));
            for(int row = 0; row < n - 1; row++)
            {
                if(row == n - 2)
                {
                    Console.Write(new string(' ', n - row - 2) + new string(':', n) + new string('X', row) + ":");
                }
                else
                {
                    Console.Write(new string(' ', n - row - 2));
                    Console.Write(":");
                    Console.Write(new string('/', n - 2));
                    Console.Write(":");
                    Console.Write(new string('X', row));
                    Console.Write(":");                 
                }
               
                Console.WriteLine();
            }

            int whCounter = 1;
            for(int bottomRow = n - 1; bottomRow > 0; bottomRow--)
            {            
                if (bottomRow == 1)
                {
                    Console.Write(new string(':', n));
                }
                else
                {
                    Console.Write(":");
                    Console.Write(new string(' ', n - 2));
                    Console.Write(":");
                    Console.Write(new string('X', bottomRow - 2));
                    Console.Write(":");
                    Console.Write(new string(' ', whCounter));
                }
              
                Console.WriteLine();
                whCounter++;
            }

        }
    }
}
