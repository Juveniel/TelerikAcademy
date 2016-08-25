namespace ArmyOfCreatures.Tests
{
    using System;
    using Logic.Battles;
    using NUnit.Framework;

    [TestFixture]
    public class CreatureIdentifierTest
    {
        [Test]
        public void CreateCreatureIndentifier_ShouldThrowArgumentNulLException_WhenNull()
        {      
            Assert.Throws<ArgumentNullException>(() => CreatureIdentifier.CreatureIdentifierFromString(null));
        }

        [Test]
        public void CreateCreatureIdentifier_ShouldThrowFormatEceptionWhenNotInCorrectFormat()
        {
            Assert.Throws<IndexOutOfRangeException>(() => CreatureIdentifier.CreatureIdentifierFromString("Angel das"));
        }

        [Test]
        public void CreateCreatureIdentifier_ShouldThrowOutOfRangeEceptionWhenNotInRange()
        {
            Assert.Throws<IndexOutOfRangeException>(() => CreatureIdentifier.CreatureIdentifierFromString("Angel"));
        }

        [Test]
        public void CreateCreatureIdentifier_ShouldReturnExpectedType_WhenCorrectValueIsPassed()
        {
            var identifier = CreatureIdentifier.CreatureIdentifierFromString("Angel(1)");

            Assert.IsInstanceOf<CreatureIdentifier>(identifier);
        }

        [Test]
        public void CreateCreatureIdentifier_ShouldReturnExpectedCreatureType_WhenCorrectValueIsPassed()
        {
            var identifier = CreatureIdentifier.CreatureIdentifierFromString("Angel(1)");

            Assert.AreEqual("Angel", identifier.CreatureType);
        }

        [Test]
        public void CreateCreatureIdentifier_ShouldReturnExpectedArmyNumber_WhenCorrectValueIsPassed()
        {
            var identifier = CreatureIdentifier.CreatureIdentifierFromString("Angel(1)");

            Assert.AreEqual(1, identifier.ArmyNumber);
        }

        [Test]
        public void CreateToString_ShouldReturnExpectedString()
        {
            var identifier = CreatureIdentifier.CreatureIdentifierFromString("Angel(1)");

            var result = identifier.ToString();

            Assert.AreEqual("Angel(1)", result);
        }
    }
}
