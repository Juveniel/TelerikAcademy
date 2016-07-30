﻿namespace Poker.Models
{
    using System.Collections.Generic;
    using Contracts;

    public class Hand : IHand
    {       
        public Hand(IList<ICard> cards)
        {
            this.Cards = cards;
        }

        public IList<ICard> Cards { get; private set; }

        public override string ToString()
        {
            return string.Join(" ", this.Cards);
        }
    }
}
