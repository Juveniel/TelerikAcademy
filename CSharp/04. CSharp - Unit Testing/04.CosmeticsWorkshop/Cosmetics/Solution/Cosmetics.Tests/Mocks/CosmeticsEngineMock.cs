namespace Cosmetics.Tests.Mocks
{
    using System.Collections;
    using System.Collections.Generic;
    using Cosmetics.Engine;
    using Cosmetics.Contracts;

    internal class CosmeticsEngineMock : CosmeticsEngine
    {
        public CosmeticsEngineMock(ICosmeticsFactory factory, IShoppingCart shoppingCart) 
            : base(factory, shoppingCart)
        {
        }

        public IDictionary<string, ICategory> Categories
        {
            get
            {
                return this.categories;                
            }
        }

        public IDictionary<string, IProduct> Products
        {
            get
            {
                return this.products;                
            }
        }


    }
}
