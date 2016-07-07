namespace Cosmetics.Products
{
    using System.Text;
    using Common;
    using Contracts;

    public abstract class Product : IProduct
    {
        private const int MinProductNameLength = 3;
        private const int MinBrandNameLength = 2;
        private const int MaxNameStrLength = 10;

        private const string ProductNamePlaceholder = "Product name";
        private const string BrandNamePlaceholder = "Product brand";

        private string name;
        private string brand;

        protected Product(string name, string brand, decimal price, GenderType gender)
        {
            this.Name = name;
            this.Brand = brand;
            this.Price = price;
            this.Gender = gender;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, string.Format(GlobalErrorMessages.StringCannotBeNullOrEmpty, ProductNamePlaceholder));
                Validator.CheckIfStringLengthIsValid(
                    value,
                    MaxNameStrLength,
                    MinProductNameLength,
                    string.Format(GlobalErrorMessages.InvalidStringLength, ProductNamePlaceholder, MinProductNameLength, MaxNameStrLength));

                this.name = value;
            }
        }

        public string Brand
        {
            get
            {
                return this.brand;
            }

            set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, string.Format(GlobalErrorMessages.StringCannotBeNullOrEmpty, BrandNamePlaceholder));
                Validator.CheckIfStringLengthIsValid(
                    value,
                    MaxNameStrLength,
                    MinBrandNameLength,
                    string.Format(GlobalErrorMessages.InvalidStringLength, BrandNamePlaceholder, MinBrandNameLength, MaxNameStrLength));

                this.brand = value;
            }
        }

        public decimal Price { get; protected set; }

        public GenderType Gender { get; private set; }

        public virtual string Print()
        {
            var productInformation = new StringBuilder();
            productInformation.AppendLine(string.Format("- {0} - {1}:", this.Brand, this.Name));
            productInformation.AppendLine(string.Format("  * Price: ${0}", this.Price));
            productInformation.AppendLine(string.Format("  * For gender: {0}", this.Gender));

            return productInformation.ToString().Trim();
        }
    }
}