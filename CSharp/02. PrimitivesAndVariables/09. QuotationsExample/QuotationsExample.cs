using System;

namespace _09.QuotationsExample
{
    /// <summary>
    /// Declare 2 string variables with value: 
    /// "The "user" of quotations causes difficulties."
    /// </summary>
    class QuotationsExample
    {
        static void Main(string[] args)
        {
            string escapedStr = "The \"use\" of quotations causes difficulties!";
            string quotedStr = @"The ""use"" of quotations causes difficulties!";

            Console.WriteLine("Escaped string: " + escapedStr);
            Console.WriteLine("Quoted string: " + quotedStr);
        }
    }
}
