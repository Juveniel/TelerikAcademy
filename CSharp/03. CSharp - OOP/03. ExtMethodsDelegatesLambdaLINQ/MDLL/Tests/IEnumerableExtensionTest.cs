namespace MDLL.Tests
{
    using System;
    using System.Linq;
    using System.Text;
    using MDLL.Extensions;

    public class IEnumerableExtensionTest
    {
        public static void Test()
        {
            // Create some custom collection
            double[] numbers = new double[5];

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i + 1.25;
                sb.AppendFormat("{0:F2} ", numbers[i]);
            }

            // Initial state
            Console.WriteLine($"Task 2. Initial state: \r\n {sb.ToString()}");

            // Extension methods tests
            Console.WriteLine($"Sum of the collection: {numbers.Sum()}");
            Console.WriteLine($"Product of the collection: {numbers.Product()}");
            Console.WriteLine($"Min of the collection: {numbers.Min()}");
            Console.WriteLine($"Max of the collection: {numbers.Max()}");
            Console.WriteLine($"Average of the collection: {numbers.Average()} \n");
        }
    }
}
