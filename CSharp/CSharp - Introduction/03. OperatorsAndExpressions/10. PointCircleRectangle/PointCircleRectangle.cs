using System;

namespace _10.PointCircleRectangle
{
    /// <summary>
    /// Write a program that reads a pair of coordinates x and y and uses an
    /// expression to checks for given point (x, y) if it is within the circle 
    /// K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).
    /// </summary>
    class PointCircleRectangle
    {
        static void Main(string[] args)
        {
            double pointX = double.Parse(Console.ReadLine());
            double pointY = double.Parse(Console.ReadLine());

            double radius = 1.5;

            bool isInCircle = (pointX - 1) * (pointX - 1) + (pointY - 1) * (pointY - 1) <= radius * radius;
            bool isInRectangle = false;
            if (pointX >= -1 && pointX <= 5 && pointY <= 1 && pointY >= -1)
            {
                isInRectangle = true;
            }

            if(isInCircle && isInRectangle)
            {
                Console.WriteLine("inside circle inside rectangle");
            }
            else if (!isInCircle && isInRectangle)
            {
                Console.WriteLine("outside circle inside rectangle");
            }
            else if (isInCircle && !isInRectangle)
            {
                Console.WriteLine("inside circle outside rectangle");
            }
            else
            {
                Console.WriteLine("outside circle outside rectangle");
            }
        }
    }
}
