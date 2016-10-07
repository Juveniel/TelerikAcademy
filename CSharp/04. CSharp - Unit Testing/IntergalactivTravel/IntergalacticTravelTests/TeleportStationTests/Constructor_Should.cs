using System.Collections.Generic;
using IntergalacticTravel.Contracts;
using IntergalacticTravelTests.TeleportStationTests.Mocks;
using NUnit.Framework;
using Moq;

namespace IntergalacticTravelTests.TeleportStationTests
{
    [TestFixture]
    public class ConstructorShould
    {
        [Test]
        public void ShouldSetUpAllFileds_WhenNewTeleportStationIsCreatedWithValidParameters()
        {
            // Arrange
            var mockedOwner = new Mock<IBusinessOwner>();
            var mockedGalacticMap= new Mock<IEnumerable<IPath>>();
            var mockedLocation = new Mock<ILocation>();

            // Act
            var teleportStation = new TeleportStationMock(mockedOwner.Object, mockedGalacticMap.Object, mockedLocation.Object);

            // Assert
            Assert.AreSame(mockedOwner.Object, teleportStation.Owner);
            Assert.AreSame(mockedLocation.Object, teleportStation.Location);
            Assert.AreSame(mockedGalacticMap.Object, teleportStation.GalacticMap);
        }
    }
}
