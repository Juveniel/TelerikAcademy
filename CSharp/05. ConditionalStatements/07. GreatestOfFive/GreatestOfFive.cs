using System;

namespace _07.GreatestOfFive
{
    class GreatestOfFive
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int firstNum = rnd.Next(1, 1000); 
            int secondNum = rnd.Next(1, 100); 
            int thirdNum = rnd.Next(1, 100);
            int fourthNum = rnd.Next(1, 100);
            int fifthNum = rnd.Next(1, 1000);

            int[] numberArr = new int[] {firstNum, secondNum, thirdNum, fourthNum, fifthNum };

            int maxValue = 0;
            for(int i = 0; i < numberArr.Length; i++)
            {
                Console.WriteLine(numberArr[i]);
                int currentNum = numberArr[i];
                if(currentNum > maxValue)
                {
                    maxValue = currentNum;
                }
            }

            Console.WriteLine("The biggest number is: {0}", maxValue);
        }
    }
}
