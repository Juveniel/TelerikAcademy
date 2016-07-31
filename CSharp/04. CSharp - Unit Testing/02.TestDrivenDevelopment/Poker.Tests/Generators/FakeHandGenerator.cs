namespace Poker.Tests.Generators
{
    using System;
    using System.Collections.Generic;
    using Contracts;
    using Enumerations;
    using Poker.Models;

    public class FakeHandGenerator : IHand
    {
        public FakeHandGenerator(int count)
        {
            this.Cards = GenerateHand(count);
        }

        public FakeHandGenerator(IList<ICard> cards)
        {
            this.Cards = cards;
        }

        public IList<ICard> Cards { get; private set; }

        private IList<ICard> GenerateHand(int numberOfCards)
        {
            var rnd = new Random();
            var faces = Enum.GetValues(typeof(CardFace));
            var suits = Enum.GetValues(typeof(CardSuit));
            var fakeHand = new List<ICard>();

            for (var i = 0; i < numberOfCards; i++)
            {
                var fakeCard = new Card(
                    (CardFace)faces.GetValue(rnd.Next(faces.Length)),
                    (CardSuit)suits.GetValue(rnd.Next(suits.Length)));

                fakeHand.Add(fakeCard);
            }

            return fakeHand;
        }
    }
}
