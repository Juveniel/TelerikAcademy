﻿using System;

namespace _06.CalcRectanglePerimeterAndArea
{
    /// <summary>
    /// Write a program that prints on the console the perimeter
    /// and the area of a rectangle by given side and height entered by the user.
    /// </summary>
    class CalcRectanglePerimeterAndArea
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter side length: ");
            int sideLenght = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter height: ");
            int height = int.Parse(Console.ReadLine());

            int rectanglePerimeter = (2 * sideLenght) + (2 * height);
            int rectangleArea = sideLenght * height;

            Console.WriteLine("The perimeter of the rectangle is equal to {0}", rectanglePerimeter);
            Console.WriteLine("The area of the rectangle is equal to {0}", rectangleArea);                 
        }
    }
}
