using System;

namespace _04.TriangleSurface
{
    /// <summary>
    /// Write program that calculates the surface of a triangle by given a side and an altitude to it.
    /// </summary>
    class TriangleSurface
    {
        static void Main(string[] args)
        {
            double tirangleSide = double.Parse(Console.ReadLine());
            double triangleSideAltitude = double.Parse(Console.ReadLine());

            double tirangleSurface = FindTriangleSurface(tirangleSide, triangleSideAltitude);
            Console.WriteLine("{0:F2}", tirangleSurface);
        }

        private static double FindTriangleSurface(double side, double altitude)
        {
            double area = (1d / 2d) * side * altitude;

            return area;
        }
    }
}
