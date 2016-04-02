using System;

namespace _04.Rectangles
{
    /// <summary>
    /// Write an expression that calculates rectangle’s perimeter and area by 
    /// given width and height. The width and height should be read from the console.
    /// </summary>
    class Rectangles
    {
        static void Main(string[] args)
        {
            double sideLenght = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double rectanglePerimeter = (2 * sideLenght) + (2 * height);
            double rectangleArea = sideLenght * height;

            Console.WriteLine("{0:F2} {1:F2}", rectangleArea, rectanglePerimeter);
        }
    }
}
