using System;

namespace _04.FormattingNumbers
{
    /// <summary>
    /// The program then prints them in 4 virtual columns on the console. 
    /// Each column should have a width of 10 characters.
    /// </summary>
    class FormattingNumbers
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());      
            double fractionPositiveNum = double.Parse(Console.ReadLine());
            double fractionNegativeNum = double.Parse(Console.ReadLine());
            string hexValue = num.ToString("X");

            Console.Write("{0}", hexValue.ToString().PadRight(3, ' '));
            Console.Write("|");
            Console.Write("{0}", Convert.ToString(num, 2).PadRight(3, ' '));
            Console.Write("|");
            Console.Write("{0:F2}", fractionPositiveNum.ToString().PadLeft(3, ' '));
            Console.Write("|");
            Console.Write("{0:F3}", fractionNegativeNum.ToString().PadRight(4, ' '));
            Console.Write("|");
            Console.WriteLine();
        }
    }
}
