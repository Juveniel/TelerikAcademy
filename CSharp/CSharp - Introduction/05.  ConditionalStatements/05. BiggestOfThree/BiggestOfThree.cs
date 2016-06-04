using System;

namespace _05.BiggestOfThree
{
    /// <summary>
    /// 
    /// </summary>
    class BiggestOfThree
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());
            double thirdNum = double.Parse(Console.ReadLine());

            double biggestNumber = 0;
            if (firstNum > secondNum)
            {
                if (firstNum > thirdNum)
                {
                    biggestNumber = firstNum;
                }
                else
                {
                    biggestNumber = thirdNum;
                }
            }
            else
            {
                if (secondNum > thirdNum)
                {
                    biggestNumber = secondNum;
                }
                else
                {
                    biggestNumber = thirdNum;
                }
            }

            Console.WriteLine("{0}", biggestNumber);
        }
    }
}
