using ArmyOfCreatures.Tests.MockedClasses;

namespace ArmyOfCreatures.Tests
{
    using System;
    using Logic;
    using Logic.Battles;
    using Logic.Creatures;
    using Moq;
    using NUnit.Framework;
    using Ploeh.AutoFixture;
    using Ploeh.AutoFixture.Kernel;

    [TestFixture]
    public class BattleManagerTest
    {
        [Test]
        public void AddCreatures_WhenIdentifierIsNull_ShouldThrowArgumentException()
        {
            // Arrange
            var mockedFactory = new Mock<ICreaturesFactory>();
            var mockedLogger = new Mock<ILogger>();

            // Act
            var battleManager = new BattleManager(null, mockedLogger.Object);

            // Assert
            Assert.Throws<ArgumentNullException>(()=> battleManager.AddCreatures(null, 1));
        }

        [Test]
        public void AddCreature_FactoryShouldCallCreateCreature_WhenValidIdentifierIsPassed()
        {
            //Arrange
            var mockedFactory = new Mock<ICreaturesFactory>();
            var mockedLogger = new Mock<ILogger>();

            var battleManager = new BattleManager(mockedFactory.Object, mockedLogger.Object);

            var fixture = new Fixture();

            fixture.Customizations.Add(
                new TypeRelay(
                    typeof(Creature),
                    typeof(Angel)));

            var creature = fixture.Create<Creature>();

            mockedFactory.Setup(x => x.CreateCreature(It.IsAny<string>())).Returns(creature);

            var identifier = CreatureIdentifier.CreatureIdentifierFromString("Angel(1)");

            // Act
            battleManager.AddCreatures(identifier, 1);

            //Assert
            mockedFactory.Verify(x => x.CreateCreature(It.IsAny<string>()), Times.Exactly(1));
        }

        [Test]
        public void AddCreature_WriteLineShouldBeCalledByLogger_WhenValidIdentifierIsPassed()
        {
            //Arrange
            var mockedFactory = new Mock<ICreaturesFactory>();
            var mockedLogger = new Mock<ILogger>();

            var battleManager = new BattleManager(mockedFactory.Object, mockedLogger.Object);

            var fixture = new Fixture();

            fixture.Customizations.Add(
                new TypeRelay(
                    typeof(Creature),
                    typeof(Angel)));

            var creature = fixture.Create<Creature>();

            mockedFactory.Setup(x => x.CreateCreature(It.IsAny<string>())).Returns(creature);
            mockedLogger.Setup(x => x.WriteLine(It.IsAny<string>()));

            var identifier = CreatureIdentifier.CreatureIdentifierFromString("Angel(1)");

            // Act
            battleManager.AddCreatures(identifier, 1);

            //Assert
            mockedLogger.Verify(x => x.WriteLine(It.IsAny<string>()), Times.Once);
        }

        [Test]
        public void Attack_WhenAttackingCreatureIDentifierIsNull_ShouldThrowArgumentException()
        {
            // Arrange
            var mockedFactory = new Mock<ICreaturesFactory>();
            var mockedLogger = new Mock<ILogger>();

            var battleManager = new BattleManager(mockedFactory.Object, mockedLogger.Object);

            //Act 
            var identifier = CreatureIdentifier.CreatureIdentifierFromString("Test(1)");

            // Assert
            Assert.Throws<ArgumentException>(()=> battleManager.Attack(identifier, identifier));
        }

        [Test]
        public void Attack_WhenDefendingCreatureIDentifierIsNull_ShouldThrowArgumentException()
        {
            // Arrange
            var mockedFactory = new Mock<ICreaturesFactory>();
            var mockedLogger = new Mock<ILogger>();

            var battleManager = new BattleManager(mockedFactory.Object, mockedLogger.Object);

            var identifierAttacker = CreatureIdentifier.CreatureIdentifierFromString("Angel(1)");
            var identifierDefender = CreatureIdentifier.CreatureIdentifierFromString("Angel(2)");

            var creature = new Angel();

            mockedLogger.Setup(x => x.WriteLine(It.IsAny<string>()));
            mockedFactory.Setup(x => x.CreateCreature(It.IsAny<string>())).Returns(creature);

            //Act 
            battleManager.AddCreatures(identifierAttacker, 1);

            // Assert & act
            Assert.Throws<ArgumentException>(() => battleManager.Attack(identifierAttacker, identifierDefender));
        }

        [Test]
        public void Attack_WhenAttackIsSuccessfull_ShouldCallWriteLine4Times()
        {
            // Arrange
            var mockedFactory = new Mock<ICreaturesFactory>();
            var mockedLogger = new Mock<ILogger>();                    
            var battleManager = new MockedBattleManager(mockedFactory.Object, mockedLogger.Object);

            var identifierAttacker = CreatureIdentifier.CreatureIdentifierFromString("Angel(1)");     
            var identifierDefender = CreatureIdentifier.CreatureIdentifierFromString("Angel(2)");     
                 
            var creature = new Angel(); 

            mockedLogger.Setup(x => x.WriteLine(It.IsAny<string>()));
            mockedFactory.Setup(x => x.CreateCreature(It.IsAny<string>())).Returns(creature);

            battleManager.AddCreatures(identifierAttacker, 1);
            battleManager.AddCreatures(identifierDefender, 2);

            // Act         
            battleManager.Attack(identifierAttacker, identifierDefender);

            // Assert
            mockedLogger.Verify(x => x.WriteLine(It.IsAny<string>()), Times.Exactly(4));
        }

        [Test]
        public void Attack_WhenAttackingOwnArmy_ShouldThrowArgumentException()
        {
            var mockedFactory = new Mock<ICreaturesFactory>();
            var mockedLogger = new Mock<ILogger>();
            var battleManager = new MockedBattleManager(mockedFactory.Object, mockedLogger.Object);

            var identifierAttacker = CreatureIdentifier.CreatureIdentifierFromString("Angel(1)");
            var identifierDefender = CreatureIdentifier.CreatureIdentifierFromString("Angel(1)");
            var creature = new Angel();

            mockedLogger.Setup(x => x.WriteLine(It.IsAny<string>()));
            mockedFactory.Setup(x => x.CreateCreature(It.IsAny<string>())).Returns(creature);

            battleManager.AddCreatures(identifierAttacker, 1);
            battleManager.AddCreatures(identifierDefender, 1);

            // Act & Assert
            Assert.Throws<ArgumentException>(() => battleManager.Attack(identifierAttacker, identifierDefender));
        }       
    }
}
