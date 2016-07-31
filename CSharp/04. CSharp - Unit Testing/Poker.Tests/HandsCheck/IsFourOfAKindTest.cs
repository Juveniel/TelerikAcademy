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
    public class IsFourOfAKindTest
    {
        [Test]
        public void IsFourOfAKind_ShouldThrowArgumentNullException_WhenHandIsNull()
        {
            var handChecker = new PokerHandsChecker();

            Assert.Throws<ArgumentNullException>(() => handChecker.IsFourOfAKind(null));
        }

        [Test]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        [TestCase(6)]
        [TestCase(10)]
        public void IsFourOfAKind_ShouldReturnFalse_WhenInvalidCardsCount(int cardsCount)
        {
            // Arrange          
            var cards = FakeCardListGenerator.GenerateCardsList(cardsCount);
            var mockedHand = new Mock<IHand>();
            mockedHand.Setup(h => h.Cards).Returns(cards);

            // Act
            var handChecker = new PokerHandsChecker();
            var isValid = handChecker.IsFourOfAKind(mockedHand.Object);

            // Assert
            Assert.IsFalse(isValid);
        }

        [Test]
        public void IsFourOfAKind_ShouldReturnFalse_WhenDuplicateCardsInHand()
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
            var isValid = handChecker.IsFourOfAKind(mockedHand.Object);

            // Assert
            Assert.IsFalse(isValid);
        }

        [Test]
        public void IsFourOfAKind_ShouldReturnFalse_WhenFourFacesAreDifferent()
        {
            // Arrange
            var cards = new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Jack, CardSuit.Clubs),
                new Card(CardFace.Jack, CardSuit.Clubs)
            };            

            var mockedHand = new Mock<IHand>();
            mockedHand.Setup(h => h.Cards).Returns(cards);

            // Act
            var handChecker = new PokerHandsChecker();
            var isFourOfAKind = handChecker.IsFourOfAKind(mockedHand.Object);

            // Assert
            Assert.IsFalse(isFourOfAKind);
        }

        [Test]
        public void IsFourOfAKind_ShouldReturnTrue_WhenFourFacesAreTheSame()
        {
            // Arrange
            var cards = new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Jack, CardSuit.Clubs)
            };

            var mockedHand = new Mock<IHand>();
            mockedHand.Setup(h => h.Cards).Returns(cards);

            // Act
            var handChecker = new PokerHandsChecker();
            var isFourOfAKind = handChecker.IsFourOfAKind(mockedHand.Object);

            // Assert
            Assert.IsTrue(isFourOfAKind);
        }
    }
}
