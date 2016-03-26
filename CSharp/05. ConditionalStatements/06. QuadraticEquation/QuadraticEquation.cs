using System;

namespace _06.QuadraticEquation
{
    class QuadraticEquation
    {
        public static void SolveQuadraticEquation(double a, double b, double c)
        {
            double x, x1, x2;
            double diskriminant = (b * b) - (4 * (a * c));

            if (diskriminant > 0)
            {
                x1 = (-b + Math.Sqrt(diskriminant)) / (2 * a);
                x2 = (-b - Math.Sqrt(diskriminant)) / (2 * a);

                Console.WriteLine("The equation has two distinct real roots: ");
                Console.WriteLine("x1 = {0:F2}", x1);
                Console.WriteLine("x2 = {0:F2}", x2);
            }
            else if(diskriminant == 0)
            {
                x = -b / (2 * a);
                Console.WriteLine("The euqation has one double real root: ");
                Console.Write("x12 = {0}", x);
            }
            else
            {
                Console.WriteLine("The equation has no real roots.");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of a: ");
            double paramA = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the value of b: ");
            double paramB = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the value of c:");
            double paramC = double.Parse(Console.ReadLine());

            SolveQuadraticEquation(paramA, paramB, paramC);           
        }    
    }
}
