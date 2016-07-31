namespace Poker.Tests.HandsCheck
{
    using System;
    using System.Collections.Generic;
    using Common;
    using Contracts;
    using Enumerations;
    using Generators;
    using Moq;
    using NUnit.Framework;
    using Poker.Models;

    [TestFixture]
    public class IsFlushHandTest
    {
        [Test]
        public void IsFlushHand_ShouldThrowArgumentNullException_WhenHandIsNull()
        {
            var handChecker = new PokerHandsChecker();

            Assert.Throws<ArgumentNullException>(() => handChecker.IsFlush(null));
        }

        [Test]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        [TestCase(6)]
        [TestCase(10)]
        public void IsFlushHand_ShouldReturnFalse_WhenInvalidCardsCount(int cardsCount)
        {
            // Arrange          
            var cards = FakeCardListGenerator.GenerateCardsList(cardsCount);
            var mockedHand = new Mock<IHand>();
            mockedHand.Setup(h => h.Cards).Returns(cards);

            // Act
            var handChecker = new PokerHandsChecker();
            var isValid = handChecker.IsFlush(mockedHand.Object);

            // Assert
            Assert.IsFalse(isValid);
        }

        [Test]
        public void IsFlushHand_ShouldReturnFalse_WhenDuplicateCardsInHand()
        {
            // Arrange        
            var cards = new List<ICard>();
            var mockedHand = new Mock<IHand>();
            var mockedCard = new Mock<ICard>();
            mockedCard.Setup(c => c.Face).Returns(CardFace.Ace);
            mockedCard.Setup(c => c.Suit).Returns(CardSuit.Diamonds);

            for (var i = 0; i < 5; i++)
            {
                cards.Add(mockedCard.Object);
            }

            mockedHand.Setup(h => h.Cards).Returns(cards);

            // Act
            var handChecker = new PokerHandsChecker();
            var isValid = handChecker.IsFlush(mockedHand.Object);

            // Assert
            Assert.IsFalse(isValid);
        }

        [Test]
        public void IsFlushHand_ShouldReturnFalse_WhenAllCardsAreNotWithTheSameSuit()
        {
            // Arrange
            var cards = new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.Nine, CardSuit.Diamonds),
                new Card(CardFace.Jack, CardSuit.Diamonds)
            };

            var mockedHand = new Mock<IHand>();
            mockedHand.Setup(h => h.Cards).Returns(cards);

            // Act
            var handChecker = new PokerHandsChecker();
            var isFlushHand = handChecker.IsFlush(mockedHand.Object);

            // Assert
            Assert.IsFalse(isFlushHand);
        }

        [Test]
        public void IsFlushHand_ShouldReturnTrue_WhenAllCardsSuitsAreTheSame()
        {
            // Arrange
            var cards = new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Two, CardSuit.Diamonds),
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.Nine, CardSuit.Diamonds),
                new Card(CardFace.Jack, CardSuit.Diamonds)
            };

            var mockedHand = new Mock<IHand>();
            mockedHand.Setup(h => h.Cards).Returns(cards);

            // Act
            var handChecker = new PokerHandsChecker();
            var isFlushHand = handChecker.IsFlush(mockedHand.Object);

            // Assert
            Assert.IsTrue(isFlushHand);
        }
    }
}
