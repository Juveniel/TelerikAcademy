using System;

namespace _09.Trapezoids
{
    /// <summary>
    /// Write an expression that calculates trapezoid's area by given 
    /// sides a and b and height h. The three values should be read from 
    /// the console in the order shown below. All three value will be floating-point numbers.
    /// </summary>
    class Trapezoids
    {
        static void Main(string[] args)
        {
            float sideA = float.Parse(Console.ReadLine());
            float sideB = float.Parse(Console.ReadLine());
            float height = float.Parse(Console.ReadLine());

            float trapezoidArea = ((sideA + sideB) / 2) * height;

            Console.WriteLine("{0:F7}", trapezoidArea);
        }
    }
}
