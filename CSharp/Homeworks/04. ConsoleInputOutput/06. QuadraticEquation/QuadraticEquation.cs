using System;

namespace _06.QuadraticEquation
{
    /// <summary>
    /// Write a program that reads the coefficients a, b and c 
    /// of a quadratic equation ax2 + bx + c = 0 and solves it
    /// </summary>
    class QuadraticEquation
    {
        public static void SolveQuadraticEquation(double a, double b, double c)
        {
            double x, x1, x2;
            double diskriminant = (b * b) - (4 * (a * c));

            if (diskriminant > 0)
            {
                x2 = (-b + Math.Sqrt(diskriminant)) / (2 * a);
                x1 = (-b - Math.Sqrt(diskriminant)) / (2 * a);

                Console.WriteLine("{0:F2}", x1);
                Console.WriteLine("{0:F2}", x2);
            }
            else if (diskriminant == 0)
            {
                x = -b / (2 * a);
                Console.Write("{0:F2}", x);
            }
            else
            {
                Console.WriteLine("no real roots");
            }
        }

        static void Main(string[] args)
        {
            double paramA = double.Parse(Console.ReadLine());
            double paramB = double.Parse(Console.ReadLine());
            double paramC = double.Parse(Console.ReadLine());

            SolveQuadraticEquation(paramA, paramB, paramC);
        }
    }
}
