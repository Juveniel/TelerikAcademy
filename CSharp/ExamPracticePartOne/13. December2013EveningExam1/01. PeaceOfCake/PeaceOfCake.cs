using System;

namespace _01.PeaceOfCake
{
    class PeaceOfCake
    {
        static void Main(string[] args)
        {
            long a = long.Parse(Console.ReadLine());
            long b = long.Parse(Console.ReadLine());
            long c = long.Parse(Console.ReadLine());
            long d = long.Parse(Console.ReadLine());

            decimal completeCakes = (decimal)a / b + (decimal)c / d;

            long finalFractionDenominator = b * d;
            long finalFractionNominator = a * d + c * b;

            if(completeCakes >= 1)
            {
                Console.WriteLine("{0:F0}", (long)completeCakes);
            }
            else
            {
                Console.WriteLine("{0:F22}", completeCakes);
            }
            Console.WriteLine("{0}/{1}", finalFractionNominator, finalFractionDenominator);
             
        }
    }
}
