namespace Shapes.Models
{
    using System;

    public class Triangle : Shape
    {
        public Triangle(double width, double height) : base(width, height)
        {       
        }

        public override double CalculateSurface()
        {
            return this.Height * (this.Width / 2);
        }

        public override string ToString()
        {
            return string.Format(
                "Triangle: width = {0} | height = {1} | surface = {2}",
                this.Width,
                this.Height,
                this.CalculateSurface());
        }
    }
}
