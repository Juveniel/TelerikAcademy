using System;

namespace _03.Circle
{
    /// <summary>
    /// Write a program that reads from the console the radius r of a 
    /// circle and prints its perimeter and area, rounded and formatted 
    /// with 2 digits after the decimal point.
    /// </summary>
    class Circle
    {
        static void Main(string[] args)
        {
            double circleRadius = double.Parse(Console.ReadLine());

            PrintPerimeterAndArea(circleRadius);
        }

        static void PrintPerimeterAndArea(double radius)
        {
            double circlePerimeter = (2 * Math.PI) * radius;
            double circleArea = Math.PI * Math.Pow(radius, 2);

            Console.WriteLine("{0:F2} {1:F2}", circlePerimeter, circleArea);
        }
    }
}
