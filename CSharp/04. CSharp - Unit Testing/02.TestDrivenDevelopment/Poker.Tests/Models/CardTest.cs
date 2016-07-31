namespace Poker.Tests.Models
{
    using Enumerations;
    using NUnit.Framework;
    using Poker.Models;

    [TestFixture]
    public class CardTest
    {
        [Test]
        [TestCase(CardSuit.Clubs, CardFace.Ace, "A♣")]
        [TestCase(CardSuit.Diamonds, CardFace.King, "K♦")]
        [TestCase(CardSuit.Hearts, CardFace.Queen, "Q♥")]
        [TestCase(CardSuit.Spades, CardFace.Jack, "J♠")]
        public void ToString_ShouldReturnCorrectName(CardSuit suit, CardFace face, string expected)
        {
            var card = new Card(face, suit);

            Assert.AreEqual(expected, card.ToString());
        }
    }
}
