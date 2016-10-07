using System;
using NUnit.Framework;
using IntergalacticTravel;
using IntergalacticTravel.Contracts;
using Moq;

namespace IntergalacticTravelTests.UnitTests
{
    [TestFixture]
    public class PayShould
    {
        [Test]
        public void ThrowNullReferenceException_WhenThePassedObjectIsNull()
        {
            // Arrange
            const int anyId = 5;
            const string anyName = "asdasd";

            var unit = new Unit(anyId, anyName);

            // Act && Assert
            Assert.Throws<NullReferenceException>(() => unit.Pay(null));
        }

        [Test]
        public void DecreaseTheAmountOfResources_ByTheAmountOfTheCost()
        {
            // Arrange
            var resources = new Mock<IResources>();
            resources.SetupGet(c => c.BronzeCoins).Returns(100);
            resources.SetupGet(c => c.SilverCoins).Returns(200);
            resources.SetupGet(c => c.GoldCoins).Returns(300);

            var cost = new Mock<IResources>();
            cost.SetupGet(c => c.BronzeCoins).Returns(10);
            cost.SetupGet(c => c.SilverCoins).Returns(20);
            cost.SetupGet(c => c.GoldCoins).Returns(30);

            const int anyId = 5;
            const string anyName = "asdasda";
            var unit = new Unit(anyId, anyName);

            unit.Resources.Add(resources.Object);

            var expectedBronze = unit.Resources.BronzeCoins - cost.Object.BronzeCoins;
            var expectedSilver = unit.Resources.SilverCoins - cost.Object.SilverCoins;
            var expectedGold = unit.Resources.GoldCoins - cost.Object.GoldCoins;

            // Act
           unit.Pay(cost.Object);

            // Assert
            Assert.AreEqual(expectedBronze, unit.Resources.BronzeCoins);
            Assert.AreEqual(expectedSilver, unit.Resources.SilverCoins);
            Assert.AreEqual(expectedGold, unit.Resources.GoldCoins);
        }

        [Test]
        public void ReturnResourceObject_WithAmountOfResourcesInTheCostObject()
        {
            // Arrange
            var cost = new Mock<IResources>();
            cost.SetupGet(c => c.BronzeCoins).Returns(10);
            cost.SetupGet(c => c.SilverCoins).Returns(20);
            cost.SetupGet(c => c.GoldCoins).Returns(30);

            const int anyId = 5;
            const string anyName = "asdasda";
            var unit = new Unit(anyId, anyName);

            // Act
            var result = unit.Pay(cost.Object);

            // Assert
            Assert.AreEqual(30, result.GoldCoins);
            Assert.AreEqual(20, result.SilverCoins);
            Assert.AreEqual(10, result.BronzeCoins);       
        }
    }
}
