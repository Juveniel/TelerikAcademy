namespace Cosmetics.Products
{
    using System.Collections.ObjectModel;
    using System.Linq;
    using Common;
    using Contracts;

    public class ShoppingCart : IShoppingCart
    {
        private readonly Collection<IProduct> products;

        public ShoppingCart()
        {
            this.products = new Collection<IProduct>();
        }

        public void AddProduct(IProduct product)
        {
            Validator.CheckIfNull(product, string.Format(GlobalErrorMessages.ObjectCannotBeNull, "Product to add to cart"));
            this.products.Add(product);
        }

        public void RemoveProduct(IProduct product)
        {
            Validator.CheckIfNull(product, string.Format(GlobalErrorMessages.ObjectCannotBeNull, "Product to remove from cart"));
            this.products.Remove(product);
        }

        public bool ContainsProduct(IProduct product)
        {
            return this.products.Contains(product);
        }

        public decimal TotalPrice()
        {
            return this.products.Sum(pr => pr.Price);
        }
    }
}
