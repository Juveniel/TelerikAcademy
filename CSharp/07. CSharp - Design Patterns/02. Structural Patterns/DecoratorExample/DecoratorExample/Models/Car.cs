using System;
using DecoratorExample.Models.Contracts;

namespace DecoratorExample.Models
{
    public class Car : ICar
    {
        public virtual void Assemble()
        {
            Console.WriteLine("Car assembled");
        }
    }
}
