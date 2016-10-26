using System;
using FactoryMethod.Factory;
using FactoryMethod.Factory.Abstract;

namespace FactoryMethod
{
    internal class Startup
    {
        private static void Main()
        {
            var creators = new Creator[2];

            creators[0] = new ConcreteCreatorA();
            creators[1] = new ConcreteCreatorB();

            // Iterate over creators and create products
            foreach (var creator in creators)
            {
                var product = creator.FactoryMethod();

                Console.WriteLine($"Created {product.GetType().Name}");
            }
        }
    }
}
