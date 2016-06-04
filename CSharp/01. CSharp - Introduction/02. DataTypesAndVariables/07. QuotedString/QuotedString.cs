using System;

namespace _07.QuotedString
{
    /// <summary>
    /// Write a program that outputs The "use" of quotations causes difficulties.
    /// </summary>
    class QuotedString
    {
        static void Main(string[] args)
        {
            string quotedStr = @"The ""use"" of quotations causes difficulties.";
            Console.WriteLine(quotedStr);
        }
    }
}
