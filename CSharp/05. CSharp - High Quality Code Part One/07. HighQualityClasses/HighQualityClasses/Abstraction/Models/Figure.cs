namespace Abstraction.Models
{
    using Contracts;

    internal abstract class Figure : IFigure
    {                         
        public abstract double CalculatePerimeter();

        public abstract double CalculateArea();

        public override string ToString()
        {
            var output =
                $"I am a {this.GetType().Name}. " +
                $"My Perimeter is: {this.CalculatePerimeter():F2}. " +
                $"My Surface is: {this.CalculateArea():F3}";          

            return output;
        }
    }
}
