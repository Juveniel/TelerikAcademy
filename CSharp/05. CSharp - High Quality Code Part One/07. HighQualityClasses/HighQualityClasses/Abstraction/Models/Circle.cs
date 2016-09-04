namespace Abstraction.Models
{
    using System;
    using Contracts;

    internal class Circle : Figure, ICircle
    {
        private double radius;

        public Circle()
        {
        }

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius
        {
            get
            {
                return this.radius;                 
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Radius cannot be null");
                }

                this.radius = value;                
            }
        }
                       
        public override double CalculatePerimeter()
        {
            var perimeter = 2 * Math.PI * this.Radius;

            return perimeter;
        }

        public override double CalculateArea()
        {
            var surface = Math.PI * this.Radius * this.Radius;

            return surface;
        }
    }
}
