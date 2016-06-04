using System;
using System.Collections.Generic;

namespace _03.Trapezoid
{
    class Trapezoid
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var widthTop = n;
            var widthBottom = n * 2;
            var height = n + 1;

            char symbol = '*';
            char dot = '.';

            Console.WriteLine(new string(dot, n) + new string(symbol, n));
            for (int i = 1; i < n; i++)
            {
                Console.WriteLine(new string(dot, n - i) + symbol + new string(dot, n - 2 + i) + symbol);
            }
            Console.WriteLine(new string(symbol, widthBottom));
        }
    }
}
