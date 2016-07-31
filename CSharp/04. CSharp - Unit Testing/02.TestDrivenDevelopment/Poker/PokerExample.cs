namespace Poker
{
    using System;
    using System.Collections.Generic;
    using Common;
    using Contracts;
    using Enumerations;
    using Models;
    
    public class PokerExample
    {
        internal static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            ICard card = new Card(CardFace.Ace, CardSuit.Clubs);
            Console.WriteLine(card);

            IHand hand = new Hand(new List<ICard>()
            { 
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Hearts),
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Diamonds),
            });
            Console.WriteLine(hand);

            IPokerHandsChecker checker = new PokerHandsChecker();
            Console.WriteLine(checker.IsValidHand(hand));
            Console.WriteLine(checker.IsOnePair(hand));
            Console.WriteLine(checker.IsTwoPair(hand));
        }

        private static IList<ICard> GenerateHand(int numberOfCards)
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
