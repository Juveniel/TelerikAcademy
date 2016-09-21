namespace _02.CompareMathOperations
{
    using System;
    using System.Diagnostics;

    internal class MathOperationsPerformance
    {
        private const int Count = 1000;

        private static readonly Stopwatch Sw = new Stopwatch();
        private static readonly Random Rnd = new Random();

        public static int GetRandomValue()
        {
            return Rnd.Next(1, int.MaxValue);
        }

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
            Sw.Start();

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

            Sw.Stop();
            Console.WriteLine($"Int test passed. Total elapsed: {Sw.Elapsed}");
            Sw.Reset();
        }

        private static void LongTest()
        {
            long result = GetRandomValue();
            Sw.Start();

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

            Sw.Stop();
            Console.WriteLine($"Long test time elapsed: {Sw.Elapsed}");
            Sw.Reset();
        }

        private static void FloatTest()
        {
            float result = GetRandomValue();
            Sw.Start();

            for (var i = 0; i < Count; i++)
            {              
                result += GetRandomValue(); 
                result -= GetRandomValue(); 
                result++; 
                result *= GetRandomValue(); 
                result /= GetRandomValue();                 
            }

            Sw.Stop();
            Console.WriteLine($"Float tests time elapsed: {Sw.Elapsed}");
            Sw.Reset();
        }

        private static void DoubleTest()
        {
            double result = GetRandomValue();
            Sw.Start();

            for (var i = 0; i < Count; i++)
            {                
                result += GetRandomValue(); 
                result -= GetRandomValue(); 
                result++;      
                result *= GetRandomValue(); 
                result /= GetRandomValue();                 
            }

            Sw.Stop();
            Console.WriteLine($"Double test time elapsed {Sw.Elapsed}: ");
            Sw.Reset();
        }

        private static void DecimalTest()
        {
            decimal result = GetRandomValue();
            Sw.Start();

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

            Sw.Stop();
            Console.WriteLine($"Decimal test time elapsed: {Sw.Elapsed}");
            Sw.Reset();
        }        
    }
}
