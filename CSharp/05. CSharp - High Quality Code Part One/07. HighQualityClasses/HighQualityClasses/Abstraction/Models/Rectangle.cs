namespace Abstraction.Models
{
    using System;
    using Contracts;

    internal class Rectangle : Figure, IRectangle
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get
            {
                return this.width;                
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width cannot be null");
                }

                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;                
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height cannot be null");
                }

                this.height = value;                
            }
        }
              
        public override double CalculatePerimeter()
        {
            var perimeter = 2 * (this.Width + this.Height);

            return perimeter;
        }

        public override double CalculateArea()
        {
            var surface = this.Width * this.Height;

            return surface;
        }       
    }
}
