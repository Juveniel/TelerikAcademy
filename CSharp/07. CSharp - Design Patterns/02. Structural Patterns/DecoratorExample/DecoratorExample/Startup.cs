using DecoratorExample.Models;

namespace DecoratorExample
{
    internal class Startup
    {
        private static void Main()
        {
            /* Car Instance */
            var carInstance = new Car();
            carInstance.Assemble();
        
            /* Decorator Instance */
            var carDecorator = new CarDecorator(carInstance);
            carDecorator.Assemble();
        }
    }
}
