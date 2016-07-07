namespace Cosmetics.Products
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Text;
    using Common;
    using Contracts;

    public class Category : ICategory
    {
        private const int MinCategoryNameLength = 2;
        private const int MaxCategoryNameLength = 15;

        private string name;
        private IList<IProduct> products;

        public Category(string name)
        {
            this.Name = name;
            this.products = new List<IProduct>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, string.Format(GlobalErrorMessages.StringCannotBeNullOrEmpty, "Category name"));
                Validator.CheckIfStringLengthIsValid(
                    value,
                    MaxCategoryNameLength,
                    MinCategoryNameLength,
                    string.Format(GlobalErrorMessages.InvalidStringLength, "Category name", MinCategoryNameLength, MaxCategoryNameLength));

                this.name = value;
            }
        }

        public void AddCosmetics(IProduct cosmetics)
        {
            Validator.CheckIfNull(cosmetics, string.Format(GlobalErrorMessages.ObjectCannotBeNull, "Added product"));

            this.products.Add(cosmetics);
        }

        public void RemoveCosmetics(IProduct cosmetics)
        {
            Validator.CheckIfNull(cosmetics, string.Format(GlobalErrorMessages.ObjectCannotBeNull, "Removed product"));
            if (!this.products.Contains(cosmetics))
            {
                throw new InvalidOperationException(string.Format("Product {0} does not exist in categoru {1}!", cosmetics.Name, this.name));
            }

            this.products.Remove(cosmetics);
        }

        public string Print()
        {
            var sortedProducts = this.products.OrderBy(x => x.Brand).ThenByDescending(x => x.Price);

            var categoryList = new StringBuilder();

            categoryList.AppendLine(string.Format("{0} category - {1} {2} in total", this.name, this.products.Count, this.products.Count == 1 ? "product" : "products"));
            foreach (var product in sortedProducts)
            {
                categoryList.AppendLine(product.Print());
            }

            return categoryList.ToString().Trim();
        }
    }
}
