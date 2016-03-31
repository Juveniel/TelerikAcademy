using System;

namespace _02.MoonWeight
{
    /// <summary>
    /// Write a program that calculates the weight of a man on the moon 
    /// by a given weight W(as a floating-point number) on the Earth.
    /// </summary>
    class MoonWeight
    {
        static void Main(string[] args)
        {
            double weight = double.Parse(Console.ReadLine());
            double weightOnTheMoon = (17 * weight) / 100;

            Console.WriteLine("{0:F3}", weightOnTheMoon);
        }
    }
}
