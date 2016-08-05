namespace Cosmetics
{
    using Cosmetics.Engine;
    using Cosmetics.Products;

    public class CosmeticsProgram
    {
        public static void Main()
        {
            var factory = new CosmeticsFactory();
            var shoppingCart = new ShoppingCart();
            var engine = new CosmeticsEngine(factory, shoppingCart);

            engine.Start();
        }
    }
}
