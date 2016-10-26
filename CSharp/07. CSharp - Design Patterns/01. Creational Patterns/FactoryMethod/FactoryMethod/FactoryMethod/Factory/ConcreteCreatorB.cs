using System;
using FactoryMethod.Factory.Abstract;
using FactoryMethod.Models;
using FactoryMethod.Models.Abstract;

namespace FactoryMethod.Factory
{
    public class ConcreteCreatorB : Creator
    {
        public override Product FactoryMethod()
        {
            return new ConcreteProductB();
        }
    }
}
