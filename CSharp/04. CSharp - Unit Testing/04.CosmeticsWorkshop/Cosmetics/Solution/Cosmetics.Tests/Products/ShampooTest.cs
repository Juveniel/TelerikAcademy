namespace Cosmetics.Tests.Products
{
    using System.Text;
    using Cosmetics.Common;
    using Cosmetics.Products;
    using NUnit.Framework;

    [TestFixture]
    public class ShampooTest
    {
        [Test]
        public void Print_ShouldReturnShampooDetailsCorrectly()
        {
            // Arrange
            var name = "testSh";
            var brand = "wash&go";
            var price = 12M;
            var gender = GenderType.Women;
            var quantity = 150;
            var type = UsageType.Medical;

            var shampoo = new Shampoo(name, brand, price, gender, (uint)quantity, type);

            var expectedPrint = new StringBuilder();
            expectedPrint.AppendLine($"- {brand} - {name}:");
            expectedPrint.AppendLine($"  * Price: ${price * quantity}");
            expectedPrint.AppendLine($"  * For gender: {gender}");
            expectedPrint.AppendLine($"  * Quantity: {quantity} ml");
            expectedPrint.Append($"  * Usage: {type}");
            
            // Act
            var actualPrint = shampoo.Print();

            // Assert
            Assert.AreEqual(expectedPrint.ToString(), actualPrint);
        }
    }
}
