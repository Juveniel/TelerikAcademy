namespace Abstraction
{
    using System;
    using Models;

    internal class Startup
    {
        internal static void Main()
        {
            // Circle Demo
            var circle = new Circle(5);
            Console.WriteLine(circle.ToString());

            // Rectangle Demo
            var rectanlge = new Rectangle(2, 3);
            Console.WriteLine(rectanlge.ToString());
        }
    }
}
