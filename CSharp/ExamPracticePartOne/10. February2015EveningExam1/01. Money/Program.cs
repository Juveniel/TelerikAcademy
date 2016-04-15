using System;

namespace _01.Money
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int s = int.Parse(Console.ReadLine());
            double p = double.Parse(Console.ReadLine());

            int totalSheets = n * s;
            double realms = (double)totalSheets / 400;
            double totalPrice = realms * p;

            Console.WriteLine("{0:F3}", totalPrice);

        }
    }
}
