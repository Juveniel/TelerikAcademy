namespace Methods
{
    using System;
    using Contracts;
    using Models;
    using Utils;

    public class Startup
    {
        internal static void Main()
        {
            Console.WriteLine(MathHelper.CalculateTriangleArea(1, 2, 3));

            Console.WriteLine(MathHelper.NumberToWord(9));

            Console.WriteLine(MathHelper.FindMaxValue(15, -10, 20, 10, 4));

            PrinterHelper.PrintAsNumber(2.6, "f");
            PrinterHelper.PrintAsNumber(5.90, "%");
            PrinterHelper.PrintAsNumber(10.10, "r");

            bool horizontal;
            bool vertical;
            Console.WriteLine(MathHelper.CalculateDistance(3, -1, 3, 2.5, out horizontal, out vertical));
            Console.WriteLine("Horizontal? " + horizontal);
            Console.WriteLine("Vertical? " + vertical);

            IStudent peter = new Student("Peter", "Ivanov", "17.03.1992", "Sofia");
            IStudent stella = new Student("Stella", "Markova", "03.11.1993", "Vidin", "gamer, high results");

            Console.WriteLine($"{peter.FirstName} older than {stella.FirstName} -> {peter.IsOlderThan(stella)}");
        }
    }
}
