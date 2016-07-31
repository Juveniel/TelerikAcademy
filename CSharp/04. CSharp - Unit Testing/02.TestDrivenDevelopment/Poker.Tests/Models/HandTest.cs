namespace Poker.Tests.Models
{   
    using System.Collections.Generic;
    using Contracts;
    using Generators;
    using NUnit.Framework;
    using Poker.Models;  

    [TestFixture]
    public class HandTest
    {
        [Test]
        public void ToString_ShouldNotReturnHand_WhenNoCollection()
        {
            var cards = new List<ICard>();
            var hand = new Hand(cards);

            Assert.AreEqual(string.Empty, hand.ToString());
        }

        [Test]
        [TestCase(5)]
        [TestCase(15)]
        [TestCase(20)]
        [TestCase(24)]
        public void ToString_ShouldReturnCorrectHand(int count)
        {
            var cards = FakeCardListGenerator.GenerateCardsList(count);
            var hand = new Hand(cards);

            var expectedString = string.Join(" ", cards);
            var actualString = hand.ToString(); 

            Assert.AreEqual(expectedString, actualString);            
        }
    }
}
