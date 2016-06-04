using System;

namespace _07.Workdays
{
    /// <summary>
    /// Write a method that calculates the number of workdays between today and a given date, 
    /// passed as parameter. Consider that workdays are all days from Monday to Friday except 
    /// a fixed list of public holidays specified preliminary as array.
    /// </summary>
    class Workdays
    {
        private static readonly string[] WeekWorkdays = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };
        private static readonly DateTime[] holidays = new DateTime[]
        {
            new DateTime(2016, 1, 1),
            new DateTime(2016, 2, 2),
            new DateTime(2016, 3, 3),
            new DateTime(2016, 5, 9),
            new DateTime(2016, 5, 10)
        };


        static void Main()
        {
            Console.WriteLine("Please enter a date in format YYYY/MM/DD");
            DateTime endDate = DateTime.Parse(Console.ReadLine());
            DateTime startDate = DateTime.Today;


            Console.WriteLine(FindWorkingDaysForPeriod(startDate, endDate));
        }

        private static int FindWorkingDaysForPeriod(DateTime startDate, DateTime endDate)
        {
            int workDaysCount = 0;
            bool isHoliday = false;

            if (startDate > endDate)
            {
                throw new ArgumentException("Incorrect end period date " + endDate);
            }

            while (startDate <= endDate)
            {
                if (startDate.DayOfWeek != DayOfWeek.Saturday && startDate.DayOfWeek != DayOfWeek.Sunday)
                {

                    for (int j = 0; j < holidays.Length; j++)
                    {
                        if (startDate == holidays[j])
                        {
                            isHoliday = true;
                            break;
                        }
                    }

                    if (!isHoliday)
                    {
                        workDaysCount++;
                    }

                    isHoliday = false;           
                }
                startDate = startDate.AddDays(1);
            }

            return workDaysCount;
        }
    }
}
