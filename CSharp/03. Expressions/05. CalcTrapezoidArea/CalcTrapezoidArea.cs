using System;

namespace _05.CalcTrapezoidArea
{
    class CalcTrapezoidArea
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter side a:");
            int sideA = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter side b: ");
            int sideB = int.Parse(Console.ReadLine());

            Console.WriteLine("Ënter height: ");
            int height = int.Parse(Console.ReadLine());

            int trapezoidArea = height * ((2 * sideA + 2 * sideB) / 2);

            Console.WriteLine("The area of the trapezoid is: {0}", trapezoidArea);
        }
    }
}
