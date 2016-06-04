using System;

namespace _01.Garden
{
    class Garden
    {
        static void Main(string[] args)
        {
            double tomatoesSeed = double.Parse(Console.ReadLine());
            double tomatoesArea = double.Parse(Console.ReadLine());

            double cucumberSeeds = double.Parse(Console.ReadLine());
            double cucumberArea = double.Parse(Console.ReadLine());

            double potatoesSeed = double.Parse(Console.ReadLine());
            double potatoesArea = double.Parse(Console.ReadLine());

            double carrotsSeed = double.Parse(Console.ReadLine());
            double carrotsArea = double.Parse(Console.ReadLine());

            double cabbageSeed = double.Parse(Console.ReadLine());
            double cabbageArea = double.Parse(Console.ReadLine());

            double beansAmount = double.Parse(Console.ReadLine());

            double totalCost = (tomatoesSeed * 0.5) + (cucumberSeeds * 0.4) +
                               (potatoesSeed * 0.25) + (carrotsSeed * 0.6) +
                               (cabbageSeed * 0.3) + (beansAmount * 0.4);

            Console.WriteLine("Total costs: {0:F2}", totalCost);

            double consumedArea = tomatoesArea + cucumberArea + potatoesArea + carrotsArea + cabbageArea;
            double totalArea = 250d;

            if(consumedArea < totalArea)
            {
                Console.WriteLine("Beans area: {0:F0}", totalArea - consumedArea);
            }
            else if (consumedArea == totalArea)
            {
                Console.WriteLine("No area for beans");                           
            }
            else
            {
                Console.WriteLine("Insufficient area");
            }
        }
    }
}
