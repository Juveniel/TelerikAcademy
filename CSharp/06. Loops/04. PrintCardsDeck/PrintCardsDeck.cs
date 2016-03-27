using System;

namespace _04.PrintCardsDeck
{
    /// <summary>
    /// Write a program that prints all possible cards from a standard deck of cards,
    /// without jokers (there are 52 cards: 4 suits of 13 cards).
    /// </summary>
    class PrintCardsDeck
    {
        static void Main(string[] args)
        {
            string[] cards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            string[] suits = { "clubs", "diamonds", "hearts", "spades" };

            foreach(string suit in suits)
            {
                Console.WriteLine("{0} : ", suit.ToUpper());
                Console.WriteLine("==============");

                foreach(string card in cards)
                {
                    Console.WriteLine("{0} of {1}", card, suit);
                }

                Console.WriteLine();
            }
        }
    }
}
