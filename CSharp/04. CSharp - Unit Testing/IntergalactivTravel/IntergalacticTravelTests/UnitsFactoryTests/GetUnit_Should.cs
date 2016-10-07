using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using IntergalacticTravel;
using IntergalacticTravel.Exceptions;


namespace IntergalacticTravelTests.UnitsFactoryTests
{
    [TestFixture]
    public class GetUnitShould
    {
        [Test]
        public void ReturnNewProcyonUnit_WhenValidCorrespondingCommandIsPassed()
        {
            // Arrange
            var factory = new UnitsFactory();

            // Act
            var unit = factory.GetUnit("create unit Procyon Gosho 1");

            // Assert
            Assert.IsInstanceOf<Procyon>(unit);
        }

        [Test]
        public void ReturnNewLuytenUnit_WhenValidCorrespondingCommandIsPassed()
        {
            // Arrange
            var factory = new UnitsFactory();

            // Act
            var unit = factory.GetUnit("create unit Luyten Pesho 1");

            // Assert
            Assert.IsInstanceOf<Luyten>(unit);
        }

        [Test]
        public void ReturnNewLacaillenUnit_WhenValidCorrespondingCommandIsPassed()
        {
            // Arrange
            var factory = new UnitsFactory();

            // Act
            var unit = factory.GetUnit("create unit Lacaille Tosho 1");

            // Assert
            Assert.IsInstanceOf<Lacaille>(unit);
        }

        [TestCase("create unit Alabala Toncho 2")]
        [TestCase("invalid string command")]
        public void ThrowInInvalidUnitCreationCommandException_WhenInvalidCommandIsPassed(string command)
        {
            // Arrange
            var factory = new UnitsFactory();

            // Act && Assert
            Assert.Throws<InvalidUnitCreationCommandException>(() => factory.GetUnit(command));
        }
    }
}
