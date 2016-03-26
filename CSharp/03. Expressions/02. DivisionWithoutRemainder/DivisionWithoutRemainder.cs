using System;

namespace _02.DivisionWithoutRemainder
{
    class DivisionWithoutRemainder
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int inputNum = int.Parse(Console.ReadLine());

            if(inputNum % 5 == 0  && inputNum % 7 == 0)
            {
                Console.WriteLine("No reaminder !");
            }
            else{
                Console.WriteLine("There is a remainder !");
            }
        }
    }
}
