using System;
using System.Collections.Generic;
using NUnit.Framework;
using IntergalacticTravel;
using IntergalacticTravel.Contracts;
using Moq;

namespace IntergalacticTravelTests.BusinessOwnerTests
{
    [TestFixture]
    public class CollectProfitsShould
    {
        [Test]
        public void IncreaseTheOwnedResources_ByTheReturnedAmount()
        {
            // Arrange
            const int id = 1;
            const string nickName = "nikcName";
            var teleportStations = new List<ITeleportStation>();

            var mockedStationPeshoProfit = new Mock<IResources>();
            mockedStationPeshoProfit.SetupGet(s => s.BronzeCoins).Returns(20);
            mockedStationPeshoProfit.SetupGet(s => s.SilverCoins).Returns(30);
            mockedStationPeshoProfit.SetupGet(s => s.GoldCoins).Returns(40);

            var mockedStationGoshoProfit = new Mock<IResources>();
            mockedStationGoshoProfit.SetupGet(s => s.BronzeCoins).Returns(5);
            mockedStationGoshoProfit.SetupGet(s => s.SilverCoins).Returns(10);
            mockedStationGoshoProfit.SetupGet(s => s.GoldCoins).Returns(15);

            var mockedStationGosho = new Mock<ITeleportStation>();
            mockedStationGosho.Setup(s => s.PayProfits(It.IsAny<IBusinessOwner>()))
                .Returns(mockedStationGoshoProfit.Object);

            var mockedStationPesho = new Mock<ITeleportStation>();
            mockedStationPesho.Setup(s => s.PayProfits(It.IsAny<IBusinessOwner>()))
                .Returns(mockedStationPeshoProfit.Object);

            teleportStations.Add(mockedStationPesho.Object);
            teleportStations.Add(mockedStationGosho.Object);

            var owner = new BusinessOwner(id, nickName, teleportStations);

            var expectedBronze = mockedStationGoshoProfit.Object.BronzeCoins + mockedStationPeshoProfit.Object.BronzeCoins;
            var expecteSilver = mockedStationGoshoProfit.Object.SilverCoins + mockedStationPeshoProfit.Object.SilverCoins;
            var expecteGold = mockedStationGoshoProfit.Object.GoldCoins + mockedStationPeshoProfit.Object.GoldCoins;

            // Act
            owner.CollectProfits();

            // Assert
            Assert.AreEqual(expectedBronze, owner.Resources.BronzeCoins);
            Assert.AreEqual(expecteSilver, owner.Resources.SilverCoins);
            Assert.AreEqual(expecteGold, owner.Resources.GoldCoins);
        }
    }
}
