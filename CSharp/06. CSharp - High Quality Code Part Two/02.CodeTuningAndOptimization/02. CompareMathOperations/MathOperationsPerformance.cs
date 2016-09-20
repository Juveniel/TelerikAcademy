namespace _02.CompareMathOperations
{
    using System;
    using System.Diagnostics;

    internal class MathOperationsPerformance
    {
        private static readonly Stopwatch sw = new Stopwatch();
        private static readonly Random rnd = new Random();
        private const int Count = 1000;

        internal static void Main()
        {
            IntTest();
            LongTest();
            FloatTest();
            DoubleTest();
            DecimalTest();
        }

        private static void IntTest()
        {
            var result = GetRandomValue();
            sw.Start();

            for (var i = 0; i < Count; i++)
            {
                unchecked
                {
                    result += GetRandomValue(); 
                    result -= GetRandomValue(); 
                    result++; 
                    result *= GetRandomValue(); 
                    result /= GetRandomValue(); 
                }
            }

            sw.Stop();
            Console.WriteLine($"Int test passed. Total elapsed: {sw.Elapsed}");
            sw.Reset();
        }

        private static void LongTest()
        {
            long result = GetRandomValue();
            sw.Start();

            for (var i = 0; i < Count; i++)
            {
                unchecked
                {
                    result += GetRandomValue(); 
                    result -= GetRandomValue(); 
                    result++; 
                    result *= GetRandomValue(); 
                    result /= GetRandomValue(); 
                }
            }

            sw.Stop();
            Console.WriteLine($"Long test time elapsed: {sw.Elapsed}");
            sw.Reset();
        }

        private static void FloatTest()
        {
            float result = GetRandomValue();
            sw.Start();

            for (var i = 0; i < Count; i++)
            {              
                result += GetRandomValue(); 
                result -= GetRandomValue(); 
                result++; 
                result *= GetRandomValue(); 
                result /= GetRandomValue();                 
            }

            sw.Stop();
            Console.WriteLine($"Float tests time elapsed: {sw.Elapsed}");
            sw.Reset();
        }

        private static void DoubleTest()
        {
            double result = GetRandomValue();
            sw.Start();

            for (var i = 0; i < Count; i++)
            {                
                result += GetRandomValue(); 
                result -= GetRandomValue(); 
                result++;      
                result *= GetRandomValue(); 
                result /= GetRandomValue();                 
            }

            sw.Stop();
            Console.WriteLine($"Double test time elapsed {sw.Elapsed}: ");
            sw.Reset();
        }

        private static void DecimalTest()
        {
            decimal result = GetRandomValue();
            sw.Start();

            for (var i = 0; i < Count; i++)
            {
                unchecked
                {
                    result += GetRandomValue();
                    result -= GetRandomValue();
                    result++;               
                    result /= GetRandomValue();
                }                
            }

            sw.Stop();
            Console.WriteLine($"Decimal test time elapsed: {sw.Elapsed}");
            sw.Reset();
        }

        public static int GetRandomValue()
        {
            return rnd.Next(1, int.MaxValue);
        }
    }
}
