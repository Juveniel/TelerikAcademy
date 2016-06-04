using System;
using System.Text.RegularExpressions;

namespace _23.SeriesOfLetters
{
    /// <summary>
    /// Write a program that reads a string from the console and replaces
    /// all series of consecutive identical letters with a single one.
    /// </summary>
    class SeriesOfLetterss
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            var regex = new Regex("(.)\\1+");
            Console.WriteLine(regex.Replace(text, "$1")); 
        }    
    }
}
