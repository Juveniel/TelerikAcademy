using System;

namespace _05.ThirdDigit
{
    /// <summary>
    /// Write a program that reads an integer N from the console 
    /// and prints true if the third digit of the N is 7, or "false 
    /// THIRD_DIGIT", where you should print the third digits of N.
    /// </summary>
    class ThirdDigit
    {
        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());
            int thirdDigit = (inputNum / 100) % 10;

            if (thirdDigit == 7)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false {0}", thirdDigit);
            }                    
        }
    }
}
