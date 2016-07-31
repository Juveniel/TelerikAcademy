namespace Poker.Tests.Generators
{   
    using System;
    using System.Collections.Generic;
    using Contracts;
    using Enumerations;
    using Poker.Models;

    public static class FakeCardListGenerator 
    {     
        public static IList<ICard> GenerateCardsList(int numberOfCards)
        {
            var rnd = new Random();
            var faces = Enum.GetValues(typeof(CardFace));
            var suits = Enum.GetValues(typeof(CardSuit));
            var fakeList = new List<ICard>();

            for (var i = 0; i < numberOfCards; i++)
            {
                var fakeCard = new Card(
                    (CardFace)faces.GetValue(rnd.Next(faces.Length)),
                    (CardSuit)suits.GetValue(rnd.Next(suits.Length)));               

                fakeList.Add(fakeCard);
            }

            return fakeList;
        }
    }
}
