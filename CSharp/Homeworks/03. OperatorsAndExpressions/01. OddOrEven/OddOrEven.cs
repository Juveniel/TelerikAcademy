using System;

namespace _01.OddOrEven
{
    /// <summary>
    /// Output a single line - if the number is even, output even, 
    /// followed by a whitespace and the value of the number. Otherwise, 
    /// print odd, again followed by a whitespace and the number's value
    /// </summary>
    class OddOrEven
    {
        static void Main(string[] args)
        {
            int inputValue = int.Parse(Console.ReadLine());

            if (inputValue % 2 == 0)
            {
                Console.WriteLine("even {0}", inputValue);
            }
            else
            {
                Console.WriteLine("odd {0}", inputValue);
            }
        }
    }
}
