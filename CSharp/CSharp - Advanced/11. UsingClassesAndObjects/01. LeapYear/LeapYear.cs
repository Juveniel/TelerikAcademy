using System;

namespace _01.LeapYear
{
    /// <summary>
    /// Write a program that reads a year from the
    /// console and checks whether it is a leap one.
    /// </summary>
    class LeapYear
    {
        static void Main()
        {
            int year = int.Parse(Console.ReadLine());

            Console.WriteLine(IsLeapYear(year));
        }

        private static string IsLeapYear(int year)
        {
            string yearType = String.Empty;

            if (DateTime.IsLeapYear(year))
            {
                yearType = "Leap";
            }
            else
            {
                yearType = "Common";
            }

            return yearType;
        }
    }
}
