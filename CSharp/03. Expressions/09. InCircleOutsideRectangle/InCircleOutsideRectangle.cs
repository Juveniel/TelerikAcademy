using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.InCircleOutsideRectangle
{
    class InCircleOutsideRectangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter point x value: ");
            int pointX = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter point y value: ");
            int pointY = int.Parse(Console.ReadLine());

            double radius = 1.5;

            bool isInCircle = (pointX - 1) * (pointX - 1) + (pointY - 1) * (pointY - 1) <= radius * radius;
            if (isInCircle && pointY > 1)
            {
                Console.WriteLine("The point is in the circle and outside the rectangle: {0}", isInCircle);
            }
            else
            {
                Console.WriteLine("The point is in the circle and outside the rectangle: {0}", isInCircle);
            }
        }
    }
}
