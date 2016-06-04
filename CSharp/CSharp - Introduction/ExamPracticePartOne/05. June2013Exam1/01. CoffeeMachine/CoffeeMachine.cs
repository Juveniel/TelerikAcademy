using System;

namespace _01.CoffeeMachine
{
    class CoffeeMachine
    {
        static void Main(string[] args)
        {
            int[] numbersArr = new int[5];
            for(int i = 0; i < 5; i++)
            {
                numbersArr[i] = int.Parse(Console.ReadLine());
            }

            double a = double.Parse(Console.ReadLine());
            double p = double.Parse(Console.ReadLine());

            double totalAmounInMachine = 0.05 * numbersArr[0] + 0.10 * numbersArr[1] +
                0.20 * numbersArr[2] + 0.50 * numbersArr[3] + 1.00 * numbersArr[4];
            double change = a - p;
           
            if (p > a)
            {
                Console.WriteLine("More {0:F2}", p - a);
            }
            else if (totalAmounInMachine >= change)
            {
                Console.WriteLine("Yes {0:F2}", totalAmounInMachine - change);
            }
            else if(change > totalAmounInMachine)
            {
                Console.WriteLine("No {0:F2}", change - totalAmounInMachine);
            }

        }
    }
}
