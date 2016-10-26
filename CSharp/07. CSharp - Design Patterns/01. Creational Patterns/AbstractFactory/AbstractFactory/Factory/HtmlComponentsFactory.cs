using AbstractFactory.Factory.Contracts;
using AbstractFactory.Models;
using AbstractFactory.Models.Contracts;

namespace AbstractFactory.Factory
{
    public class HtmlComponentsFactory : IHtmlComponentsFactory
    {
        public IButton CreateButton()
        {
            return new Button();
        }

        public IDatepicker CreateDatepicker()
        {
            return new Datepicker();            
        }
    }
}
