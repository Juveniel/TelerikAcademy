using System;

namespace _01.CartesianSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal pointX = decimal.Parse(Console.ReadLine());
            decimal pointY = decimal.Parse(Console.ReadLine());

            if (pointX == 0 && pointY == 0)
            {
                Console.Write(0);
            }
            else if (pointX > 0 && pointY > 0)
            {
                Console.WriteLine(1);
            }
            else if (pointX > 0 && pointY < 0)
            {
                Console.WriteLine(4);
            }
            else if (pointX < 0 && pointY > 0) {
                Console.WriteLine(2);
            }
            else if (pointX < 0 && pointY < 0)
            {
                Console.WriteLine(3);
            }
            else if (pointX == 0 && pointY > 0)
            {
                Console.WriteLine(5);
            }
            else
            {
                Console.WriteLine(6);
            }

        }
    }
}
