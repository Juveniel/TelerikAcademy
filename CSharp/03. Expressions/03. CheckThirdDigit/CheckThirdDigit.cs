using System;

namespace _03.CheckThirdDigit
{
    class CheckThirdDigit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int inputNum = int.Parse(Console.ReadLine());

            if(inputNum > 99) {
                int thirdDigit = (inputNum / 100) % 10;

                if(thirdDigit == 7)
                {
                    Console.WriteLine("The third digit is 7");
                }
                Console.WriteLine("The third digit of your number is: {0}", thirdDigit);
            }
            else
            {
                Console.WriteLine("Number is too small !");
            }
        }
    }
}
