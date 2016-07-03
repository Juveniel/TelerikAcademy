namespace MDLL.Tests
{
    using System;
    using System.Text;
    using MDLL.Extensions;

    public class StringBuilderExtensionTest
    {
        public static void Test()
        {
            // Task 1.======================================
            Console.WriteLine("Task1. Stringbuilder extension test");
            StringBuilder input = new StringBuilder();
            input.AppendLine("Lorem ipsum dolor sit amet");

            Console.WriteLine("String: {0}", input.ToString());

            Console.WriteLine("First ext method overload");
            Console.WriteLine(input.Substring(6, 5).ToString());

            Console.WriteLine("Second ext method overload");
            Console.WriteLine(input.Substring(12).ToString());
        }
    }
}
