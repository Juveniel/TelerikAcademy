using System;

namespace _01.MathExpression
{
    class MathExpression
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double m = double.Parse(Console.ReadLine());
            double p = double.Parse(Console.ReadLine());
        
            double expression = (((n * n) + (1.0 / (m * p)) + 1337) / (n - (128.523123123 * p))) + Math.Sin((int)m % 180);
            Console.WriteLine("{0:F6}", expression);
        }
    }
}
