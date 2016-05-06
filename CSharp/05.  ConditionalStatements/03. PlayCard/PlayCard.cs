using System;
using System.Linq;

namespace _03.PlayCard
{
    /// <summary>
    /// Write a program that prints all possible cards from a standard deck of cards,
    /// without jokers (there are 52 cards: 4 suits of 13 cards).
    /// </summary>
    class PlayCard
    {
        static void Main(string[] args)
        {
            string inputCard = Console.ReadLine();       
            string[] cards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

            if (cards.Contains(inputCard))
            {
                Console.WriteLine("yes {0}", inputCard);
            }
            else
            {
                Console.WriteLine("no {0}", inputCard);
            }
        }
    }
}
