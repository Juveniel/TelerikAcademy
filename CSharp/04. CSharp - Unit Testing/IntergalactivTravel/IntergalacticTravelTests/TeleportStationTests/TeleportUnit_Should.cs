using System;
using System.Collections.Generic;
using NUnit.Framework;
using IntergalacticTravel;
using IntergalacticTravel.Contracts;
using Moq;

namespace IntergalacticTravelTests.TeleportStationTests
{
    [TestFixture]
    public class TeleportUnitShould
    {
        [Test]
        public void ThrowArgumentNullException_WhenUnitToTeleportIsNull()
        {
            // Arrange
            var mockedOwner = new Mock<IBusinessOwner>();
            var mockedGalacticMap = new Mock<IEnumerable<IPath>>();
            var mockedLocation = new Mock<ILocation>();
            var mockedTargetLocation = new Mock<ILocation>();

            var mockedTeleportStation = new TeleportStation(mockedOwner.Object, mockedGalacticMap.Object, mockedLocation.Object);

            // Act && Assert
            Assert.That(() => mockedTeleportStation.TeleportUnit(null, mockedTargetLocation.Object),
                Throws.ArgumentNullException.With.Message.Contains("unitToTeleport"));
        }

        [Test]
        public void ThrowArgumentNullException_WhenDestinationIsNull()
        {
            // Arrange
            var mockedOwner = new Mock<IBusinessOwner>();
            var mockedGalacticMap = new Mock<IEnumerable<IPath>>();
            var mockedLocation = new Mock<ILocation>();
            var mockedUnitToTeleport = new Mock<IUnit>();

            var mockedTeleportStation = new TeleportStation(mockedOwner.Object, mockedGalacticMap.Object, mockedLocation.Object);

            // Act && Assert
            Assert.That(() => mockedTeleportStation.TeleportUnit(mockedUnitToTeleport.Object, null),
                Throws.ArgumentNullException.With.Message.Contains("destination"));
        }


    }
}
