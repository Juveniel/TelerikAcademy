using System;

namespace _10.BonusPoints
{
    class BonusPoints
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your score: ");
            int userScore = CheckInputRange(int.Parse(Console.ReadLine()));

            switch (userScore)
            {
                case 1:
                case 2:
                case 3:
                    userScore *= 10;
                    break;
                case 4:
                case 5:
                case 6:
                    userScore *= 100;
                    break;
                case 7:
                case 8:
                case 9:
                    userScore *= 1000;
                    break;
                default:
                    Console.WriteLine("Invalid score!");
                    break;
            }

            Console.WriteLine("Your final score (including bonus points) is: {0}", userScore);
        }

        static int CheckInputRange(int input)
        {
            while(input < 1 || input > 9)
            {
                Console.WriteLine("Please enter a correct score in range [0-9]");
                input = int.Parse(Console.ReadLine());
            }

            return input;
        }
    }
}
