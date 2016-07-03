namespace MDLL.Tests
{
    using System;
    using MDLL.Extensions;
    using MDLL.LINQ;

    public class IntegerExtensionTest
    {
        public static void Test()
        {        
            int[] numbersTest = new int[] { 1, 2, 3, 21, 54, 6, 7, 8, 9, 432, 4, 5, 67, 31, 123, 4 };

            // initial state
            Console.WriteLine("Problem 6: Divisible by 7 and 3:");
            Console.WriteLine("Collection of numbers: " + string.Join(", ", numbersTest));

            // with extension method
            var divisibleExt = numbersTest.DivisibleBy7and3();
            Console.Write("Numbers divisible by 7 and 3 (with EXT method): ");
            foreach (var result in divisibleExt)
            {
                Console.Write(result + " ");
            }

            Console.WriteLine();

            // with linq
            var divisibleLinq = DataQueries.DivibisbleBy7and3(numbersTest);
            Console.Write("Numbers divisible by 7 and 3 ( with linq): ");
            foreach (var result in divisibleExt)
            {
                Console.Write(result + " ");
            }

            Console.WriteLine("\r\n");
        }
    }
}
