using FactoryMethod.Factory.Abstract;
using FactoryMethod.Models;
using FactoryMethod.Models.Abstract;

namespace FactoryMethod.Factory
{
    public class ConcreteCreatorA : Creator
    {
        public override Product FactoryMethod()
        {
            return new ConcreteProductA();
        }
    }
}
