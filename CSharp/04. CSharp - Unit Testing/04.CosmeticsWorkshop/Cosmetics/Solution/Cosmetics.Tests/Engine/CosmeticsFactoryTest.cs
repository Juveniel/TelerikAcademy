using System.Linq;

namespace Cosmetics.Tests.Engine
{
    using System;
    using System.Collections.Generic;
    using Cosmetics.Common;
    using Cosmetics.Engine;
    using Moq;
    using NUnit.Framework;
    using Cosmetics.Products;

    [TestFixture]
    public class CosmeticsFactoryTest
    {
        [Test]
        [TestCase("")]
        [TestCase(null)]
        public void CreateShampoo_ShouldThrowNullReferenceException_WhenParamNameIsInvalid(string name)
        {
            // Arrange
            var factory = new CosmeticsFactory();

            // Act & Assert
            Assert.Throws<NullReferenceException>(
                () => factory.CreateShampoo(name, "Wash&go", 50.2M, GenderType.Unisex, 150, UsageType.EveryDay));
        }

        [Test]
        [TestCase("asdasdasdasd")]
        [TestCase("as")]
        public void CreateShampoo_ShouldThrowIndexOutOfRangeException_WhenParamNameIsNotInRange(string name)
        {
            // Arrange
            var factory = new CosmeticsFactory();

            // Act & Assert
            Assert.Throws<IndexOutOfRangeException>(
                () => factory.CreateShampoo(name, "Wash&go", 50.2M, GenderType.Unisex, 150, UsageType.EveryDay));
        }

        [Test]
        [TestCase("b")]
        [TestCase("brandbrandbrand")]
        public void CreateShampoo_ShouldThrowIndexOutOfRangeException_WhenParamBrandIsNotInRange(string brand)
        {
            // Arrange
            var factory = new CosmeticsFactory();

            // Act & Assert
            Assert.Throws<IndexOutOfRangeException>(
                () => factory.CreateShampoo("testShamp", brand , 50.2M, GenderType.Unisex, 150, UsageType.EveryDay));
        }

        [Test]
        [TestCase("")]
        [TestCase(null)]
        public void CreateShampoo_ShouldThrowNullReferenceException_WhenParamBrandIsInvalid(string brand)
        {
            // Arrange
            var factory = new CosmeticsFactory();

            // Act & Assert
            Assert.Throws<NullReferenceException>(
                () => factory.CreateShampoo("testShamp", brand, 50.2M, GenderType.Unisex, 150, UsageType.EveryDay));
        }

        [Test]
        public void CreateShampoo_ShouldReturnNewShampoo_WhenParamsAreValid()
        {
            // Arrange
            var factory = new CosmeticsFactory();

            // Act
             var shampoo = factory.CreateShampoo("testShamp", "test", 50M, GenderType.Unisex, 50, UsageType.EveryDay);          

            // Assert
            Assert.AreEqual("testShamp", shampoo.Name);
            Assert.AreEqual(typeof(Shampoo), shampoo.GetType());
        }

        [Test]
        [TestCase("")]
        [TestCase(null)]
        public void CreateCategory_ShouldThrowArgumentNullException_WhenParamNameIsNotValid(string name)
        {
            // Arrange
            var factory = new CosmeticsFactory();

            // Act & Assert
            Assert.Throws<NullReferenceException>(() => factory.CreateCategory(name));
        }

        [Test]
        [TestCase("n")]
        [TestCase("namenamenamenamenamename")]
        public void CreateCategory_ShouldThrowIndexOutOfRangeException_WhenNameIsNotInRange(string name)
        {
            // Arrange
            var factory = new CosmeticsFactory();

            // Act & Assert
            Assert.Throws<IndexOutOfRangeException>(() => factory.CreateCategory(name));
        }

        [Test]
        public void CreateCategory_ShouldReturnNewCategory_WhenParamsAreValid()
        {
            // Arrange
            var factory = new CosmeticsFactory();

            // Act
            var category = factory.CreateCategory("testCateg");

            // Assert
            Assert.AreEqual("testCateg", category.Name);
            Assert.AreEqual(typeof(Category), category.GetType());
        }

        [Test]
        [TestCase("")]
        [TestCase(null)]
        public void CreateToothpase_ShouldThrowNullReferenceException_WhenParamNameIsNotValid(string name)
        {
            // Arrange
            var factory = new CosmeticsFactory();
            var ingredients = new List<string>()
            {
                "ingredientA",
                "ingredientB",
                "ingredientC"
            };
       
            // Act & Assert
            Assert.Throws<NullReferenceException>(
                () => factory.CreateToothpaste(name, "brandT", 12.50M, GenderType.Unisex, ingredients));
        }

        [Test]
        [TestCase("a")]
        [TestCase("asdasddasdsadsadsa")]
        public void CreateToothpase_ShouldThrowIndexOutOfRangeException_WhenParamNameIsNotInRange(string name)
        {
            // Arrange
            var factory = new CosmeticsFactory();
            var ingredients = new List<string>()
            {
                "ingredientA",
                "ingredientB",
                "ingredientC"
            };

            // Act & Assert
            Assert.Throws<IndexOutOfRangeException>(
                () => factory.CreateToothpaste(name, "brandT", 12.50M, GenderType.Unisex, ingredients));
        }

        [Test]
        [TestCase("")]
        [TestCase(null)]
        public void CreateToothpase_ShouldThrowNullReferenceException_WhenParamBrandIsNotValid(string brand)
        {
            // Arrange
            var factory = new CosmeticsFactory();
            var ingredients = new List<string>()
            {
                "ingredientA",
                "ingredientB",
                "ingredientC"
            };

            // Act & Assert
            Assert.Throws<NullReferenceException>(
                () => factory.CreateToothpaste("testName", brand, 12.50M, GenderType.Unisex, ingredients));
        }

        [Test]
        [TestCase("a")]
        [TestCase("asdasddasdsadsadsa")]
        public void CreateToothpase_ShouldThrowIndexOutOfRangeException_WhenParamBrandIsNotInRange(string brand)
        {
            // Arrange
            var factory = new CosmeticsFactory();
            var ingredients = new List<string>()
            {
                "ingredientA",
                "ingredientB",
                "ingredientC"
            };

            // Act & Assert
            Assert.Throws<IndexOutOfRangeException>(
                () => factory.CreateToothpaste("testName", brand, 12.50M, GenderType.Unisex, ingredients));
        }

        [Test]
        [TestCase("in1")]
        [TestCase("ingredientlarge1", "ingredientlarge2", "ingredientlarge3")]
        public void CreateToothpase_ShouldThrowIndexOutOfRangeException_WhenParamIngredientsCountIsNotInRange(params string[] ingr)
        {
            // Arrange
            var factory = new CosmeticsFactory();
            var ingredients = ingr.ToList();            

            // Act & Assert
            Assert.Throws<IndexOutOfRangeException>(
                () => factory.CreateToothpaste("testName", "brand", 12M, GenderType.Unisex, ingredients));
        }

        [Test]
        public void CreateShoppingCart_ShouldAlwaysReturnNewCart()
        {
            // Arrange
            var factory = new CosmeticsFactory();           
            
            // Act
            var cart = factory.CreateShoppingCart();

            // Assert
            Assert.AreSame(typeof(ShoppingCart), cart.GetType());
        }  
    }
}
