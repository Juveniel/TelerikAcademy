namespace Cosmetics.Tests.Products
{
    using System.Text;
    using System.Collections.Generic;
    using Cosmetics.Common;
    using Cosmetics.Products;
    using NUnit.Framework;

    [TestFixture]
    public class ToothpasteTest
    {
        [Test]
        public void Print_ShouldReturnToothpasteDetailsCorrectly()
        {
            // Arrange
            var name = "testPaste";
            var brand = "Aquafresh";
            var price = 12M;
            var gender = GenderType.Women;
            var ingredients = new List<string> { "ingredient1", "ingredient2", "ingredient3" };

            var toothpaste = new Toothpaste(name, brand, price, gender, ingredients);

            var expectedPrint = new StringBuilder();
            expectedPrint.AppendLine($"- {brand} - {name}:");
            expectedPrint.AppendLine($"  * Price: ${price}");
            expectedPrint.AppendLine($"  * For gender: {gender}");
            expectedPrint.Append($"  * Ingredients: {string.Join(", ", ingredients)}");

            // Act
            var actualPrint = toothpaste.Print();

            // Assert
            Assert.AreEqual(expectedPrint.ToString(), actualPrint);
        }
    }
}
