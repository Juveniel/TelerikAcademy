namespace SolarSystem
{
    using System.Windows;

    public class PropertyHolder<TPropertyType, THoldingType> where THoldingType : DependencyObject
    {
        public PropertyHolder(string name, TPropertyType defaultValue, PropertyChangedCallback propertyChangedCallback)
        {
            this.Property = 
                DependencyProperty.Register(
                    name, 
                    typeof(TPropertyType), 
                    typeof(THoldingType), 
                    new PropertyMetadata(defaultValue, propertyChangedCallback));
        }

        public DependencyProperty Property { get; }

        public TPropertyType Get(THoldingType obj)
        {
            return (TPropertyType)obj.GetValue(this.Property);
        }

        public void Set(THoldingType obj, TPropertyType value)
        {
            obj.SetValue(this.Property, value);
        }
    }
}
