using System;
using DecoratorExample.Models.Contracts;

namespace DecoratorExample.Models
{
    public class CarDecorator : Car
    {
        private readonly ICar carProvider;

        public CarDecorator(ICar carProvider)
        {
            this.carProvider = carProvider;
        }

        public override void Assemble()
        { 
            Console.WriteLine("Decorated car assembled");
        }
    }
}
