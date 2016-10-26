using AbstractFactory.Factory;

namespace AbstractFactory
{
    internal class Startup
    {
        private static void Main()
        {
            var htmlComponents = new HtmlComponentsFactory();

            var button = htmlComponents.CreateButton();
            var datepicker = htmlComponents.CreateDatepicker();
        }
    }
}
