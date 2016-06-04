using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace _19.DatesFromTextInCanada
{
    /// <summary>
    /// Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
    /// Display them in the standard date format for Canada.
    /// </summary>
    class DatesFromTextInCanada
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            var regex = new Regex(@"\b\d{2}\.\d{2}.\d{4}\b");
            foreach (Match m in regex.Matches(text))
            {
                DateTime dt;
                if (DateTime.TryParseExact(m.Value, "dd.MM.yyyy", null, DateTimeStyles.None, out dt))
                {
                    Console.WriteLine(dt.ToString(CultureInfo.GetCultureInfo("en-CA").DateTimeFormat));
                }
                    
            }
        }
    }
}
