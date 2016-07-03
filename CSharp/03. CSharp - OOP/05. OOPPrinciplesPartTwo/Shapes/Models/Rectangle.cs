namespace Shapes.Models
{
    using System;

    public class Rectangle : Shape
    {
        public Rectangle(double width, double height) : base(width, height)
        {
        }

        public override double CalculateSurface()
        {
            return this.Width * this.Height;
        }

        public override string ToString()
        {
            return string.Format(
                "{0}: width = {1} | height = {2} | surface = {3}",
                this.GetType().Name,
                this.Width,
                this.Height,
                this.CalculateSurface());
        }
    }
}
