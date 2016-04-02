using System;

namespace _07.PointInCircle
{
    /// <summary>
    /// rite a program that reads the coordinates of a point x and y and using an 
    /// expression checks if given point (x, y) is inside a circle K({0, 0}, 2) -
    /// the center has coordinates (0, 0) and the circle has radius 2. 
    /// </summary>
    class PointInCircle
    {
        static void Main(string[] args)
        {
            double pointX = double.Parse(Console.ReadLine());
            double pointY = double.Parse(Console.ReadLine());

            double circleRadius = 2;
            double pointCoord = Math.Sqrt((pointX * pointX) + (pointY * pointY));

            if (circleRadius >= pointCoord)
            {
                Console.WriteLine("yes {0:F2}", Math.Round(pointCoord, 2));
            }
            else
            {
                Console.WriteLine("no {0:F2}", Math.Round(pointCoord, 2));
            }
        }
    }
}
