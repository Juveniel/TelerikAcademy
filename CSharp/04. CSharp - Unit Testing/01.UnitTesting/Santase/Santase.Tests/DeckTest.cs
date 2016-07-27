namespace Santase.Tests
{
    using Logic;
    using Logic.Cards;
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

            for (int i = 0; i <= count; i++)
            {
                Assert.IsNotNull(deck.GetNextCard());
            }            
        }

        [Test]
        public void Deck_ShouldThrowAnException_WhenCardsOver()
        {
            var deck = new Deck();

            for (var i = 0; i < 24; i++)
            {
                deck.GetNextCard();
            }

            Assert.Throws<InternalGameException>(() => deck.GetNextCard());
        }

    }
}
