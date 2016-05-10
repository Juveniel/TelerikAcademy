using System;
using System.Globalization;
using System.Threading;

namespace _17.DateInBulgarian
{
    /// <summary>
    /// Write a program that reads a date and time given in the format: day.month.year hour:minute:second 
    /// and prints the date and time after 6 hours and 30 minutes (in the same format) along with the day
    /// of week in Bulgarian.
    /// </summary>
    class DateInBulgarian
    {
        static void Main(string[] args)
        {
            //set current culture
            Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");

            //get format and provider
            string format = "d.M.yyyy H:m:s";
            CultureInfo provider = CultureInfo.GetCultureInfo("BG-bg");
            
            //parse date
            Console.Write("Enter the date (dd.MM.yyyy HH:mm:ss): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), format, provider);

            //print result
            date = date.AddMinutes(390);
            Console.WriteLine(date.ToString("dd.MM.yyyy HH:mm:ss dddd"), provider);
        }
    }
}
