using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.BullsAndCows
{
    class BullsAndCows
    {
        static void Main(string[] args)
        {
            int secretNumber = int.Parse(Console.ReadLine());
            int bulls = int.Parse(Console.ReadLine());
            int cows = int.Parse(Console.ReadLine());
            bool foundNum = false;

            for (int i = 1111; i <= 9999; i++)
            {
                int currentBullsCount = 0;
                int currentCowsCount = 0;

                char[] guessNumber = i.ToString().ToArray();
                char[] secret = secretNumber.ToString().ToArray();

                if (guessNumber.Contains('0'))
                {
                    continue;
                }

                for (int k = 0; k < 4; k++)
                {
                    if (guessNumber[k] == (secret[k]))
                    {
                        currentBullsCount++;
                        guessNumber[k] = secret[k] = '-';

                    }
                    else
                    {

                        int index = Array.IndexOf(guessNumber, secret[k]);

                        while (index != -1 && secret[index] == guessNumber[index])
                            index = Array.IndexOf(guessNumber, secret[k], index + 1);

                        if (index != -1)
                        {
                            currentCowsCount++;
                            guessNumber[index] = secret[k] = '-';
                        }
                       
                    }
                }

                if (bulls == currentBullsCount && cows == currentCowsCount)
                {
                    foundNum = true;
                    Console.Write(i + " ");
                }
            }
           

               
      

            if (!foundNum)
            {
                Console.WriteLine("No");
            }
        }
    }
}
