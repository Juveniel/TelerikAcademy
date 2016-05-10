using System;

namespace _11.FormatNumber
{
    /// <summary>
    /// Write a program that reads a number and prints it as a decimal number,
    /// hexadecimal number, percentage and in scientific notation.
    /// Format the output aligned right in 15 symbols.
    /// </summary>
    class FormatNumber
    {
        static void Main(string[] args)
        {
            int numberStr = int.Parse(Console.ReadLine());

            Console.WriteLine("{0,15}", numberStr);
            Console.WriteLine("{0,15:X}", numberStr);
            Console.WriteLine("{0,15:P}", numberStr);
            Console.WriteLine("{0,15:E5}", numberStr);
        }
    }
}
