using System;
using NUnit.Framework;
using IntergalacticTravel;

namespace IntergalacticTravelTests.UnitsFactoryTests
{
    [TestFixture]
    public class GetResourcesShould
    {
        [TestCase("create resources gold(20) silver(30) bronze(40)")]
        [TestCase("create resources gold(20) bronze(40) silver(30)")]
        [TestCase("create resources silver(30) bronze(40) gold(20)")]
        [TestCase("create resources silver(30) gold(20) bronze(40)")]
        [TestCase("create resources bronze(40) gold(20) silver(30)")]
        [TestCase("create resources bronze(40) silver(30) gold(20)")]
        public void ReturnNewlyCreatedResource_WhenValidInputIsPassed(string command)
        {
            // Arrange
            var factory = new ResourcesFactory();
            
            // Act
            var resources = factory.GetResources(command);

            // Assert
            Assert.IsInstanceOf<Resources>(resources);
            Assert.AreEqual(20, resources.GoldCoins);
            Assert.AreEqual(30, resources.SilverCoins);
            Assert.AreEqual(40, resources.BronzeCoins);
        }

        [TestCase("create resources a b c")]
        [TestCase("create resources alabala")]
        [TestCase("invalid string command")]
        public void ThrowInvalidOperationException_WhenInvalidCommandIsPassed(string command)
        {
            // Arrange
            var factory = new ResourcesFactory();
            
            // Act && Assert
            Assert.Throws<InvalidOperationException>(() => factory.GetResources(command));
        }
    }
}
