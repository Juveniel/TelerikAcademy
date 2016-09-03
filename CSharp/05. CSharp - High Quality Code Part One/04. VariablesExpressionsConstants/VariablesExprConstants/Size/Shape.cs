namespace Size
{
    using System;

    public class Shape
    {
        private double width;
        private double height;

        public Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width { get; set; }

        public double Height { get; set; }

        public static Shape GetRotatedShape(Shape shape, double rotationAngle)
        {
            var sinusOfRotation = Math.Abs(Math.Sin(rotationAngle));
            var cosinusOfRotation = Math.Abs(Math.Cos(rotationAngle));

            var width = (cosinusOfRotation * shape.Width) + (sinusOfRotation * shape.Height);
            var height = (sinusOfRotation * shape.Width) + (cosinusOfRotation * shape.Height);

            var rotatedShape = new Shape(width, height);

            return rotatedShape;           
        }
    }
}
