using System;

namespace _07.CalcMoonWieght
{
    /// <summary>
    /// The gravitational field of the Moon is approximately 17% 
    /// of that on the Earth.Write a program that calculates the 
    /// weight of a man on the moon by a given weight on the Earth.
    /// </summary>
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
