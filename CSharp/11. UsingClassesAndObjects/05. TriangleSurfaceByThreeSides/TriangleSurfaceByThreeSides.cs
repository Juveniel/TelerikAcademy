using System;

namespace _05.TriangleSurfaceByThreeSides
{
    /// <summary>
    /// Write program that calculates the surface of a triangle by given its three sides.
    /// </summary>
    class TriangleSurfaceByThreeSides
    {
        static void Main(string[] args)
        {
            double sideOne = double.Parse(Console.ReadLine());
            double sideTwo = double.Parse(Console.ReadLine());
            double sideThree = double.Parse(Console.ReadLine());

            Console.WriteLine("{0:F2}", CalculateArea(sideOne, sideTwo, sideThree));
        }

        //Heron's Formula
        private static double CalculateArea(double sideOne, double sideTwo, double sideThree)
        {
            double area = 0D;
            double semiperimeter = (sideOne + sideTwo + sideThree) / 2;

            area = Math.Sqrt(semiperimeter * (semiperimeter - sideOne) * (semiperimeter - sideTwo) * (semiperimeter - sideThree));

            return area;            
        }
    }
}
