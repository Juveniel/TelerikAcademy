using System;

namespace _04.PrintCardsDeck
{
    /// <summary>
    /// Write a program that reads a card sign(as a char) from the console and generates
    /// and prints all possible cards from a standard deck of 52 cards 
    /// up to the card with the given sign.
    /// </summary>
    class PrintCardsDeck
    {
        static void Main(string[] args)
        {
            string boundary = Console.ReadLine();

            string[] cards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            string[] suits = { "spades,", "clubs,", "hearts,", "diamonds" };

            int idx = Array.IndexOf(cards, boundary);
     
            for (int i = 0; i < idx + 1; i++)
            {
                foreach(string suit in suits)
                {                                                
                    Console.Write("{0} of {1} ", cards[i], suit);
                }

                Console.WriteLine();
            }                               
        }
    }
}
