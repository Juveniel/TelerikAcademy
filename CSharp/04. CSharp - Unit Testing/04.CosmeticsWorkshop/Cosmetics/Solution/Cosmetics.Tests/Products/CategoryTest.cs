namespace Cosmetics.Tests.Products
{
    using System.Text;
    using Cosmetics.Common;
    using Cosmetics.Products;
    using NUnit.Framework;

    [TestFixture]
    public class Categorytest
    {
        [Test]
        public void Print_ShouldReturnShampooDetailsCorrectly()
        {
            // Arrange
            var name = "testCat";   
            var category = new Category(name);
       
            var expectedPrint = new StringBuilder();
            expectedPrint.Append($"{name} category - {0} {"products"} in total");
                 
            // Act
            var actualPrint = category.Print();

            // Assert
            Assert.AreEqual(expectedPrint.ToString(), actualPrint);
        }
    }
}
