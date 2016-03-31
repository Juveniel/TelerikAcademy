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
            int pointX = int.Parse(Console.ReadLine());
            int pointY = int.Parse(Console.ReadLine());

            int circleRadius = 2;
            double pointCoord = Math.Sqrt((pointX * pointX) + (pointY * pointY));

            if (circleRadius >= pointCoord)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
    }
}
