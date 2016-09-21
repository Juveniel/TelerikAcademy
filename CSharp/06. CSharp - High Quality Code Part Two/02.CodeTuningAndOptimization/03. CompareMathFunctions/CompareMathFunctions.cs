namespace _03.CompareMathFunctions
{
    using System;
    using System.Diagnostics;

    public class CompareMathFunctions
    {
        private const int Count = 1000000;
        private const int SquareRootPower = 2;

        private static readonly Stopwatch Sw = new Stopwatch();
        private static readonly Random Rnd = new Random();

        private static double RandomDouble
        {
            get
            {
                var randomDouble = Rnd.NextDouble() * Rnd.Next(1, int.MaxValue);

                return randomDouble;
            }
        }

        private static void Main()
        {
            FloatTest();
            DoubleTest();
            DecimalTest();
        }        

        private static void FloatTest()
        {
            Sw.Start();
            var result = 0f;

            for (var i = 0; i < Count; i++)
            {
                result = (float)Math.Pow(RandomDouble, SquareRootPower); 
                result = (float)Math.Log10(RandomDouble); 
                result = (float)Math.Sin(RandomDouble); 
            }

            Sw.Stop();
            Console.WriteLine($"Float test time elapsed: {Sw.Elapsed}");
            Sw.Reset();
        }

        private static void DoubleTest()
        {
            Sw.Start();
            var result = 0d;

            for (var i = 0; i < Count; i++)
            {
                result = Math.Pow(RandomDouble, SquareRootPower); 
                result = Math.Log10(RandomDouble); 
                result = Math.Sin(RandomDouble); 
            }

            Sw.Stop();
            Console.WriteLine($"Double test time elapsed {Sw.Elapsed}");
            Sw.Reset();
        }

        private static void DecimalTest()
        {
            Sw.Start();
            var result = 0m;

            for (var i = 0; i < Count; i++)
            {
                result = (decimal)Math.Pow(RandomDouble, SquareRootPower); 
                result = (decimal)Math.Log10(RandomDouble); 
                result = (decimal)Math.Sin(RandomDouble); 
            }

            Sw.Stop();
            Console.WriteLine($"Decimal test time elapsed: {Sw.Elapsed}");
            Sw.Reset();
        }        
    }    
}
