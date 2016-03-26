using System;

namespace _08.IsPointInCircle
{
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
