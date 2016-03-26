using System;

namespace _07.CalcMoonWieght
{
    class CalcMoonWieght
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your weight: ");
            double weight = double.Parse(Console.ReadLine());
            double weightOnTheMoon = (17 * weight) / 100;

            Console.WriteLine("Your weight on the moon weill be approximately: {0} kg.", weightOnTheMoon);
        }
    }
}
