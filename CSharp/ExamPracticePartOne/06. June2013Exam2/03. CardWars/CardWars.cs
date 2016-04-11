using System;
using System.Collections.Generic;
using System.Numerics;

namespace _03.CardWars
{
    class CardWars
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger firstPlayerPoints = 0;
            BigInteger secondPlayerPoints = 0;

            int firstPlayerGamesWon = 0;
            int secondPlayerGamesWon = 0;

            bool firstX = false;
            bool secondX = false;

            for (int i = 0; i < n; i++)
            {
                BigInteger firstPlayerStrength = 0;
                BigInteger secondPlayerStrength = 0;

                List<string> firstPlayerCards = new List<string>();
                List<string> secondPlayerCards = new List<string>();

                for (int j = 0; j < 3; j++)
                {
                    string drawnCardFirst = Console.ReadLine();

                    if (drawnCardFirst == "X")
                    {
                        firstX = true;
                    }
                    if (drawnCardFirst == "Y")
                    {
                        firstPlayerPoints -= 200;
                    }

                    if (drawnCardFirst == "Z")
                    {
                        firstPlayerPoints *= 2;
                    }

                    firstPlayerCards.Add(drawnCardFirst);
                }

                for (int k = 0; k < 3; k++)
                {
                    string drawnCardSecond = Console.ReadLine();

                    if (drawnCardSecond == "X")
                    {
                        secondX = true;
                    }         
                    
                    if(drawnCardSecond == "Y")
                    {
                        secondPlayerPoints -= 200;
                    }    
                    
                    if(drawnCardSecond == "Z")
                    {
                        secondPlayerPoints *= 2;
                    }    

                    secondPlayerCards.Add(drawnCardSecond);
                }

                firstPlayerStrength = CalculateHandStrength(firstPlayerCards);
                secondPlayerStrength = CalculateHandStrength(secondPlayerCards);

                if (firstX && secondX)
                {
                    firstPlayerPoints += 50;
                    secondPlayerPoints += 50;
                    firstX = false;
                    secondX = false;
                }

                // Standart outcome               
                if (firstPlayerStrength > secondPlayerStrength)
                {      
                    firstPlayerPoints += firstPlayerStrength;
                    firstPlayerGamesWon += 1;

                }
                else if (secondPlayerStrength > firstPlayerStrength)
                {               
                    secondPlayerPoints += secondPlayerStrength;
                    secondPlayerGamesWon += 1;
                }              
            }


            // Case X drawn
            if (firstX && !secondX)
            {
                Console.WriteLine("X card drawn! Player one wins the match!");
                return;
            }
            else if (!firstX && secondX)
            {
                Console.WriteLine("X card drawn! Player two wins the match!");
                return;
            }

            if (firstPlayerPoints > secondPlayerPoints)
            {
                Console.WriteLine("First player wins!");
                Console.WriteLine("Score: " + firstPlayerPoints);
                Console.WriteLine("Games won: " + firstPlayerGamesWon);
            }
            else if(firstPlayerPoints < secondPlayerPoints)
            {
                Console.WriteLine("Second player wins!");
                Console.WriteLine("Score: " + secondPlayerPoints);
                Console.WriteLine("Games won: " + secondPlayerGamesWon);
            }
            else if(secondPlayerPoints == firstPlayerPoints)
            {
                Console.WriteLine("It's a tie!");
                Console.WriteLine("Score: " + firstPlayerPoints);
            }
        }

        static BigInteger CalculateHandStrength(List<string> cards)
        {
            BigInteger sum = 0;

            foreach(string card in cards)
            {
                switch (card)
                {
                    case "2":
                        sum += 10;
                        break;
                    case "3":
                        sum += 9;
                        break;
                    case "4":
                        sum += 8;
                        break;
                    case "5":
                        sum += 7;
                        break;
                    case "6":
                        sum += 6;
                        break;
                    case "7":
                        sum += 5;
                        break;
                    case "8":
                        sum += 4;
                        break;
                    case "9":
                        sum += 3;
                        break;
                    case "10":
                        sum += 2;
                        break;
                    case "A":
                        sum += 1;
                        break;
                    case "J":
                        sum += 11;
                        break;
                    case "Q":
                        sum += 12;
                        break;
                    case "K":
                        sum += 13;
                        break;      
                                         
                }
            }

            return sum;
        }             
    }
}
