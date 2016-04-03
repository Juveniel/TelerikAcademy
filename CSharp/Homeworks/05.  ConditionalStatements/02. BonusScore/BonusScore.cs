using System;

namespace _02.BonusScore
{
    /// <summary>
    /// Write a program that applies bonus score to given score 
    /// in the range [1…9] by the following rules:
    /// If the score is between 1 and 3, the program multiplies it by 10.
    /// If the score is between 4 and 6, the program multiplies it by 100.
    ///  If the score is between 7 and 9, the program multiplies it by 1000.
    /// </summary>
    class BonusScore
    {
        static void Main(string[] args)
        {
            int userScore = int.Parse(Console.ReadLine());

            switch (userScore)
            {
                case 1:
                case 2:
                case 3:
                    userScore *= 10;
                    Console.WriteLine("{0}", userScore);
                    break;
                case 4:
                case 5:
                case 6:
                    userScore *= 100;
                    Console.WriteLine("{0}", userScore);
                    break;
                case 7:
                case 8:
                case 9:
                    userScore *= 1000;
                    Console.WriteLine("{0}", userScore);
                    break;
                default:
                    Console.WriteLine("invalid score");
                    break;
            }
        }
    }
}
