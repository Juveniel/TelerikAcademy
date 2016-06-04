using System;

namespace _06.TriangleSurfaceByTwoSIdes
{
    /// <summary>
    /// Write program that calculates the surface of a triangle by given two sides and an angle between them.
    /// </summary>
    class TriangleSurfaceByTwoSIdes
    {
        static void Main()
        {
            double sideOne = double.Parse(Console.ReadLine());
            double sideTwo = double.Parse(Console.ReadLine());
            double angle = double.Parse(Console.ReadLine());

            PrintArea(sideOne, sideTwo, angle);
        }

        private static void PrintArea(double sideOne, double sideTwo, double angle)
        {
            double area = (1d / 2d) * sideOne * sideTwo * Math.Sin((angle * Math.PI) / 180d);

            Console.WriteLine("{0:F2}", area);
        }

    }
}
