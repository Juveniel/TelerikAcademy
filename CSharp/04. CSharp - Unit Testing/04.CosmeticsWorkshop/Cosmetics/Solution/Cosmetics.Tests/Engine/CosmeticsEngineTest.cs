using System.IO;
using System.Linq;
using Cosmetics.Products;
using Cosmetics.Tests.Mocks;

namespace Cosmetics.Tests.Engine
{
    using System;
    using Cosmetics.Contracts;
    using Cosmetics.Engine;
    using Moq;
    using NUnit.Framework;

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
            var cosmeticsEngineMock = new CosmeticsEngineMock(mockedFactory.Object, mockedCart.Object);

            mockedFactory.Setup(x => x.CreateCategory(It.IsAny<string>())).Returns(new Category("testCat"));
            // Act
            Console.SetIn(new StringReader("CreateCategory testCat"));             
            cosmeticsEngineMock.Start();          
           
            // Assert       
            Assert.IsTrue(cosmeticsEngineMock.Categories.ContainsKey("testCat"));
            Assert.AreEqual("testCat", cosmeticsEngineMock.Categories["testCat"].Name);
        }
    }
}
