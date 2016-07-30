namespace Poker.Models
{
    using System.Collections.Generic;
    using Contracts;
    using Enumerations;

    public class Card : ICard
    {       
        public Card(CardFace face, CardSuit suit)
        {
            this.Face = face;
            this.Suit = suit;
        }

        public CardFace Face { get; private set; }

        public CardSuit Suit { get; private set; }

        public override string ToString()
        {
            var suitSymbols = new List<string>()
            {
                "default",
                "♣",
                "♦",
                "♥",
                "♠"
            };

            return string.Format("{0}{1}", this.Face.ToString()[0], suitSymbols[(int)this.Suit]);
        }
    }
}
