namespace _03.CompareMathFunctions
{
    using System;
    using System.Diagnostics;

    public class CompareMathFunctions
    {        
        private static readonly Stopwatch sw = new Stopwatch();
        private static readonly Random rnd = new Random();

        private const int Count = 1000000;
        private const int SquareRootPower = 2;

        static void Main()
        {
            FloatTest();
            DoubleTest();
            DecimalTest();
        }

        private static void FloatTest()
        {
            sw.Start();
            var result = 0f;

            for (var i = 0; i < Count; i++)
            {
                result = (float)Math.Pow(RandomDouble, SquareRootPower); 
                result = (float)Math.Log10(RandomDouble); 
                result = (float)Math.Sin(RandomDouble); 
            }

            sw.Stop();
            Console.WriteLine($"Float test time elapsed: {sw.Elapsed}");
            sw.Reset();
        }

        private static void DoubleTest()
        {
            sw.Start();
            var result = 0d;

            for (var i = 0; i < Count; i++)
            {
                result = Math.Pow(RandomDouble, SquareRootPower); 
                result = Math.Log10(RandomDouble); 
                result = Math.Sin(RandomDouble); 
            }

            sw.Stop();
            Console.WriteLine($"Double test time elapsed {sw.Elapsed}");
            sw.Reset();
        }

        private static void DecimalTest()
        {
            sw.Start();
            var result = 0m;

            for (var i = 0; i < Count; i++)
            {
                result = (decimal)Math.Pow(RandomDouble, SquareRootPower); 
                result = (decimal)Math.Log10(RandomDouble); 
                result = (decimal)Math.Sin(RandomDouble); 
            }

            sw.Stop();
            Console.WriteLine($"Decimal test time elapsed: {sw.Elapsed}");
            sw.Reset();
        }

        private static double RandomDouble
        {
            get
            {
                var randomDouble = rnd.NextDouble() * rnd.Next(1, int.MaxValue);

                return randomDouble;
            }
        }
    }
    
}
