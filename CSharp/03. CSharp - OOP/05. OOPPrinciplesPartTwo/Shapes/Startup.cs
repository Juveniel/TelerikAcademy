namespace Shapes
{
    using System;
    using System.Collections.Generic;
    using Models;

    public class Startup
    {
        public static void Main()
        {
            List<Shape> shapes = new List<Shape>
            {
                new Square(5.50),
                new Triangle(5, 4),
                new Rectangle(7.5, 12)
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine(shape);
            }
       }            
    }
}
