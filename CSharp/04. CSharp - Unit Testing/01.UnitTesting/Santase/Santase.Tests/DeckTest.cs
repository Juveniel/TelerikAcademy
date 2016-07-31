namespace Santase.Tests
{
    using System.Collections.Generic;
    using Logic;
    using Logic.Cards;
    using System.Linq;
    using NUnit.Framework;

    [TestFixture]
    public class DeckTest
    {

        [Test]
        public void DeckTrumpCard_ShouldNotBeNull()
        {
            var deck = new Deck();

            Assert.IsNotNull(deck.TrumpCard);
        }

        [Test]
        public void Deck_ShouldHave24Cards()
        {
            var deck = new Deck();

            Assert.AreEqual(24, deck.CardsLeft);
        }

        [Test]
      
        [TestCase(5)]
        [TestCase(10)]
        [TestCase(23)]
        public void GetNextCard_ShouldThrowExceptionIfNoCardsLeft(int count)
        {
            var deck = new Deck();

            for (var i = 0; i <= count; i++)
            {
                Assert.IsNotNull(deck.GetNextCard());
            }            
        }

        [Test]
        public void GetNextCard_ShouldThrowAnException_WhenCardsOver()
        {
            var deck = new Deck();

            for (var i = 0; i < 24; i++)
            {
                deck.GetNextCard();
            }

            Assert.Throws<InternalGameException>(() => deck.GetNextCard());
        }

        [TestCase(5)]
        [TestCase(10)]
        [TestCase(15)]
        [TestCase(20)]
        [TestCase(24)]
        public void GetNextCard_ShouldReturnDifferentCards(int count)
        {
            var deck = new Deck();
            var cards = new List<Card>();

            for (var card = 0; card < count; card++)
            {
                cards.Add(deck.GetNextCard());
            }

            var filtered = cards.Distinct().ToList();

            Assert.AreEqual(count, filtered.Count);
        }
    }
}
