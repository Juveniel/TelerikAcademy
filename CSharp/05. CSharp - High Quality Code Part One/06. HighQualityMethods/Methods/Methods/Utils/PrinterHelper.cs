namespace Methods.Utils
{
    using System;

    internal static class PrinterHelper
    {
        internal static void PrintAsNumber(object number, string format)
        {
            if (number == null)
            {
                throw new ArgumentNullException("Not a number");
            }

            switch (format)
            {
                case null:
                    throw new ArgumentNullException("Invalid format");
                case "f":
                    Console.WriteLine($"{number:f2}");
                    break;
                case "%":
                    Console.WriteLine($"{number:p0}");
                    break;
                case "r":
                    Console.WriteLine($"{number,8}");
                    break;
                default:
                    throw new ArgumentException("Invalid format string.");
            }
        }
    }
}
