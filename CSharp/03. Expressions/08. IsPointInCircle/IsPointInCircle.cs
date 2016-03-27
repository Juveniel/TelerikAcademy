using System;

namespace _08.IsPointInCircle
{
    /// <summary>
    /// Write an expression that checks for a given point {x, y} if
    /// it is within the circle K[{0, 0}, R=5]. Explanation: the
    /// point {0, 0} is the center of the circle and 5 is the radius.
    /// </summary>
    class IsPointInCircle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter point x value: ");
            int pointX = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter point y value: ");
            int pointY = int.Parse(Console.ReadLine());

            int circleRadius = 5;        
            double pointCoord = Math.Sqrt((pointX * pointX) + (pointY * pointY));

            if (circleRadius >= pointCoord)
            {
                Console.WriteLine("Point in circle");
            }
            else
            {
                Console.WriteLine("Point not in circle");
            }
        }
    }
}
