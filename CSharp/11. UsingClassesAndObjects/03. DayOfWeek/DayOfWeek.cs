using System;

namespace _03.DayOfWeek
{
    /// <summary>
    /// Write a program that prints to the console which day of the week is today. Use System.DateTime.
    /// </summary>
    class DayOfWeek
    {
        static void Main()
        {
            PrintDayOFTheWeek();
        }

        private static void PrintDayOFTheWeek()
        {
            DateTime currentDate = DateTime.Today;

            Console.WriteLine(currentDate.DayOfWeek);
        }
    }
}
