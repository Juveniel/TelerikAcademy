namespace Cosmetics.Tests.Engine
{
    using System;
    using System.Collections.Generic;
    using System.IO;  
    using Contracts;
    using Cosmetics.Common;
    using Cosmetics.Engine;   
    using Mocks;
    using Moq;
    using NUnit.Framework;
    using Products;

    [TestFixture]
    public class CosmeticsEngineTest
    {
        [Test]
        public void Start_ShouldThrowArgumentNullException_WhenInputStringIsIncorrect()
        {
            // Arrange           
            var mockedFactory = new Mock<ICosmeticsFactory>();
            var mockedCart = new Mock<IShoppingCart>();
            var cosmeticsEngine = new CosmeticsEngine(mockedFactory.Object, mockedCart.Object);

            // Act
            Console.SetIn(new StringReader("CreateCategory "));

            // Assert
            Assert.Throws<ArgumentNullException>(() => cosmeticsEngine.Start());
        }

        [Test]
        public void Start_ShouldExecuteCreateCategoryCommand_WhenCreateCategoryCommandIsCalled()
        {
            // Arrange           
            var mockedFactory = new Mock<ICosmeticsFactory>();            
            var mockedCart = new Mock<IShoppingCart>();

            mockedFactory.Setup(x => x.CreateCategory(It.IsAny<string>())).Returns(new Category("testCat"));

            var cosmeticsEngineMock = new CosmeticsEngineMock(mockedFactory.Object, mockedCart.Object);

            // Act
            Console.SetIn(new StringReader("CreateCategory testCat"));             
            cosmeticsEngineMock.Start();          
           
            // Assert       
            Assert.IsTrue(cosmeticsEngineMock.Categories.ContainsKey("testCat"));
            Assert.AreEqual("testCat", cosmeticsEngineMock.Categories["testCat"].Name);
        }

        [Test]
        public void Start_ShouldExecuteAddToCategoryCommand_WhenAddToCategoryIsCalled()
        {
            // Arrange           
            var mockedFactory = new Mock<ICosmeticsFactory>();
            var mockedCart = new Mock<IShoppingCart>();
            var mockedCategory = new Mock<ICategory>();

            mockedFactory.Setup(x => x.CreateCategory(It.IsAny<string>())).Returns(new Category("testCat"));
            mockedCategory.Setup(x => x.AddCosmetics(It.IsAny<IProduct>())).Verifiable();

            var cosmeticsEngineMock = new CosmeticsEngineMock(mockedFactory.Object, mockedCart.Object);
          
            cosmeticsEngineMock.Categories.Add("testCat", mockedCategory.Object);
            cosmeticsEngineMock.Products.Add("testToothpaste", It.IsAny<IProduct>());

            // Act
            Console.SetIn(new StringReader("AddToCategory testCat testToothpaste"));
            cosmeticsEngineMock.Start();

            // Assert       
            mockedCategory.Verify(x => x.AddCosmetics(It.IsAny<IProduct>()));
        }

        [Test]
        public void Start_ShouldExecuteRemoveFromCategoryCommand_WhenRemoveFromCategoryCommandIsCalled()
        {
            // Arrange           
            var mockedFactory = new Mock<ICosmeticsFactory>();
            var mockedCart = new Mock<IShoppingCart>();
            var mockedCategory = new Mock<ICategory>();

            mockedFactory.Setup(x => x.CreateCategory(It.IsAny<string>())).Returns(new Category("testCat"));
            mockedCategory.Setup(x => x.AddCosmetics(It.IsAny<IProduct>())).Verifiable();

            var cosmeticsEngineMock = new CosmeticsEngineMock(mockedFactory.Object, mockedCart.Object);
           
            cosmeticsEngineMock.Categories.Add("testCat", mockedCategory.Object);
            cosmeticsEngineMock.Products.Add("testToothpaste", It.IsAny<IProduct>());

            // Act
            Console.SetIn(new StringReader("RemoveFromCategory testCat testToothpaste"));
            cosmeticsEngineMock.Start();

            // Assert       
            mockedCategory.Verify(x => x.RemoveCosmetics(It.IsAny<IProduct>()));
        }

        [Test]
        public void Start_ShouldExecutePrintMethod_WhenShowCategoryCommandIsCalled()
        {
            // Arrange           
            var mockedFactory = new Mock<ICosmeticsFactory>();
            var mockedCart = new Mock<IShoppingCart>();
            var mockedCategory = new Mock<ICategory>();

            mockedFactory.Setup(x => x.CreateCategory(It.IsAny<string>())).Returns(new Category("testCat"));
            mockedCategory.Setup(x => x.AddCosmetics(It.IsAny<IProduct>())).Verifiable();

            var cosmeticsEngineMock = new CosmeticsEngineMock(mockedFactory.Object, mockedCart.Object);
           
            cosmeticsEngineMock.Categories.Add("testCat", mockedCategory.Object);
            cosmeticsEngineMock.Products.Add("testToothpaste", It.IsAny<IProduct>());

            // Act
            Console.SetIn(new StringReader("ShowCategory testCat"));
            cosmeticsEngineMock.Start();

            // Assert       
            mockedCategory.Verify(x => x.Print(), Times.AtLeastOnce);
        }

        [Test]
        public void Start_ShouldExecuteCreateShampoo_WhenCreateShampooCommandIsCalled()
        {
            // Arrange           
            var mockedFactory = new Mock<ICosmeticsFactory>();
            var mockedCart = new Mock<IShoppingCart>(); 
            
            mockedFactory.Setup(x => x.CreateShampoo(
                It.IsAny<string>(),
                It.IsAny<string>(),
                It.IsAny<decimal>(),
                It.IsAny<GenderType>(),
                It.IsAny<uint>(),
                It.IsAny<UsageType>()));

            var cosmeticsEngineMock = new CosmeticsEngineMock(mockedFactory.Object, mockedCart.Object);

            // Act
            Console.SetIn(new StringReader("CreateShampoo testShampoo Wash&Go 0.50 men 200 everyday"));
            cosmeticsEngineMock.Start();

            // Assert       
            Assert.AreEqual(1, cosmeticsEngineMock.Products.Count);           
        }

        [Test]
        public void Start_ShouldExecuteCreateToothpaste_WhenCreateToothpasteCommandIsCalled()
        {
            // Arrange           
            var mockedFactory = new Mock<ICosmeticsFactory>();
            var mockedCart = new Mock<IShoppingCart>();

            mockedFactory.Setup(x => x.CreateToothpaste(
                It.IsAny<string>(),
                It.IsAny<string>(),
                It.IsAny<decimal>(),
                It.IsAny<GenderType>(),
                It.IsAny<IList<string>>()));

            var cosmeticsEngineMock = new CosmeticsEngineMock(mockedFactory.Object, mockedCart.Object);

            // Act
            Console.SetIn(new StringReader("CreateToothpaste Aquafresh Strawberry 0.50 men green,red,yellow"));
            cosmeticsEngineMock.Start();

            // Assert       
            Assert.AreEqual(1, cosmeticsEngineMock.Products.Count);
        }

        [Test]
        public void Start_ShouldRemoveFromShoppingCart_WhenRemoveFromShoppingCartCommandIsCalled()
        {
            // Arrange           
            var mockedFactory = new Mock<ICosmeticsFactory>();
            var mockedCart = new Mock<IShoppingCart>();

            mockedCart.Setup(x => x.ContainsProduct(It.IsAny<IProduct>())).Returns(true);
            mockedCart.Setup(x => x.AddProduct(It.IsAny<IProduct>())).Verifiable();

            var cosmeticsEngineMock = new CosmeticsEngineMock(mockedFactory.Object, mockedCart.Object);

            cosmeticsEngineMock.Products.Add("Aquafresh", It.IsAny<IProduct>());
        
            // Act
            Console.SetIn(new StringReader("RemoveFromShoppingCart Aquafresh"));
            cosmeticsEngineMock.Start();

            // Assert       
            mockedCart.Verify(x => x.RemoveProduct(It.IsAny<IProduct>()));
        }

        [Test]
        public void Start_ShouldAddProductToShoppingCart_WhenAddToShoppingCartCommandIsCalled()
        {
            // Arrange           
            var mockedFactory = new Mock<ICosmeticsFactory>();
            var mockedCart = new Mock<IShoppingCart>();

            mockedCart.Setup(x => x.AddProduct(It.IsAny<IProduct>())).Verifiable();

            var cosmeticsEngineMock = new CosmeticsEngineMock(mockedFactory.Object, mockedCart.Object);

            cosmeticsEngineMock.Products.Add("Aquafresh", It.IsAny<IProduct>());

            // Act
            Console.SetIn(new StringReader("AddToShoppingCart Aquafresh"));
            cosmeticsEngineMock.Start();

            // Assert       
            mockedCart.Verify(x => x.AddProduct(It.IsAny<IProduct>()));
        }
    }
}
