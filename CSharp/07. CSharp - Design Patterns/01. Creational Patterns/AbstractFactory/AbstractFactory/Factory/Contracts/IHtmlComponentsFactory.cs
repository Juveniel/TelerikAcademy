using AbstractFactory.Models.Contracts;

namespace AbstractFactory.Factory.Contracts
{
    public interface IHtmlComponentsFactory
    {
        IButton CreateButton();

        IDatepicker CreateDatepicker();
    }
}