using System;

namespace _07.SortNumbers
{
    /// <summary>
    /// Write a program that enters 3 real numbers and prints 
    /// them sorted in descending order.
    /// </summary>
    class SortNumbers
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            if (firstNum < secondNum)
            {
                if (firstNum > thirdNum)
                {
                    SwapValues(ref firstNum, ref thirdNum);
                }
            }
            else
            {
                if (secondNum < thirdNum)
                {
                    SwapValues(ref firstNum, ref secondNum);
                }
                else
                {
                    SwapValues(ref firstNum, ref thirdNum);
                }
            }


            if (secondNum > thirdNum)
            {
                SwapValues(ref secondNum, ref thirdNum);
            }

            Console.WriteLine(thirdNum + " " + secondNum + " " + firstNum);
        }

        public static void SwapValues(ref int firstNum, ref int secondNum)
        {
            int tempswap = firstNum;
            firstNum = secondNum;
            secondNum = tempswap;
        }
    }
}
