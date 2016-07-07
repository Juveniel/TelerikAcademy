namespace Cosmetics.Products
{
    using System.Text;
    using Common;
    using Contracts;

    public class Shampoo : Product, IShampoo
    {
        public Shampoo(string name, string brand, decimal price, GenderType gender, uint mililiters, UsageType usageType)
            : base(name, brand, price, gender)
        {
            this.Milliliters = mililiters;
            this.Usage = usageType;
            this.Price *= this.Milliliters;
        }

        public uint Milliliters { get; private set; }

        public UsageType Usage { get; private set; }

        public override string Print()
        {
            var shampooInformation = new StringBuilder();
            shampooInformation.AppendLine(base.Print());
            shampooInformation.AppendLine(string.Format("  * Quantity: {0} ml", this.Milliliters));
            shampooInformation.AppendLine(string.Format("  * Usage: {0}", this.Usage));

            return shampooInformation.ToString().Trim();
        }
    }
}