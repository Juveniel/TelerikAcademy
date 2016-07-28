namespace ArmyOfCreatures.Tests
{
    using System;
    using Logic;
    using Logic.Battles;
    using Moq;
    using NUnit.Framework;


    [TestFixture]
    public class BattleManagerTest
    {
        [Test]
        public void AddCreatures_WhenIdentifierIsNull_ShouldThrowArgumentException()
        {
            var mockedFactory = new Mock<ICreaturesFactory>();
            var mockedLogger = new Mock<ILogger>();

            var battleManager = new BattleManager(mockedFactory.Object, mockedLogger.Object);

            Assert.Throws<ArgumentNullException>(()=> battleManager.AddCreatures(null, 1));
        }     
    }
}
