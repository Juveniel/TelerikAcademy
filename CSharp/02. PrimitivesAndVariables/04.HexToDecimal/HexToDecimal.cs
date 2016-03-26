using System;

namespace HexToDecimal
{
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
