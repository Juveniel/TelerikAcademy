namespace ArmyOfCreatures.Tests
{    
    using System;
    using Logic;
    using NUnit.Framework;

    [TestFixture]
    public class CreaturesFactoryTest
    {
        [TestCase("Angel")]
        [TestCase("Archangel")]
        [TestCase("ArchDevil")]
        [TestCase("Behemoth")]
        [TestCase("Devil")]
        public void CreateCreature_ShouldCreateCorrectTypeOfCreature(string type)
        {
            var factory = new CreaturesFactory();

            var creature = factory.CreateCreature(type);

            Assert.AreEqual(type, creature.GetType().Name);
        }

        [Test]
        public void CreateCreature_ShouldThrowExceptionWithExpectedMessageWhenUnknownType()
        {
            var factory = new CreaturesFactory();
                  
            Assert.Throws<ArgumentException>(() => factory.CreateCreature("Unknown"));
        }        
    }
}
