using System;

namespace HexToDecimal
{
    /// <summary>
    /// Initialize a variable of type int with a value of 256 
    /// in a hexadecimal format.
    /// </summary>
    class HexToDecimal
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");

            string input = Console.ReadLine();     
            int intValue = int.Parse(input);

            Console.WriteLine(intValue.ToString("X"));
        }
    }
}
