using System;

namespace _16.DateDifference
{
    /// <summary>
    /// Write a program that reads two dates in the format:
    /// day.month.year and calculates the number of days between them.
    /// </summary>
    class DateDifference
    {
        static void Main(string[] args)
        {
            DateTime firstDate = DateTime.Parse(Console.ReadLine());
            DateTime secondDate = DateTime.Parse(Console.ReadLine());

            PrintDateDifference(firstDate, secondDate);
        }

        static void PrintDateDifference(DateTime first, DateTime second)
        {
            var diff = (second - first).TotalDays;

            Console.WriteLine("{0} days", diff);
        }
    }
}
