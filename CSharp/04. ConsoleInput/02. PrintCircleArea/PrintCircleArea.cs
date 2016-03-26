using System;

namespace _02.PrintCircleArea
{
    class PrintCircleArea
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius of the circle: ");
            double circleRadius = double.Parse(Console.ReadLine());

            PrintArea(circleRadius);
            PrintPerimeter(circleRadius);
        }

        static void PrintArea(double radius)
        {
            double circleArea = Math.PI * Math.Pow(radius, 2);

            Console.WriteLine("The area of the circle is: {0:F2}", circleArea);
        }

        static void PrintPerimeter(double radius)
        {
            double circlePerimeter = (2 * Math.PI) * radius;

            Console.WriteLine("The perimeter of the circle is: {0:F2}", circlePerimeter);
        }
    }
}
