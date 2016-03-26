using System;

namespace _01.CheckOddEven
{
    class CheckOddEven
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your number: ");
            int inputValue = int.Parse(Console.ReadLine());

            if (inputValue % 2 == 0)
            {
                Console.WriteLine("Your number is even !");
            }
            else
            {
                Console.WriteLine("Your number is odd !");
            }
        }
    }
}
