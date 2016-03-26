using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.PrintNumbersInRange
{
    class PrintNumbersInRange
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number for boundary: ");
            int upperBoundary = CheckInputFormat(Console.ReadLine());

            Console.WriteLine("===///=== RESULT ===///===");
            for(int i = 1; i <= upperBoundary; i++)
            {
                Console.WriteLine(i);
            }
        }

        static int CheckInputFormat(string input)
        {
            int result;
            while (!int.TryParse(input, out result))
            {
                Console.WriteLine("Please try again with a correct number: ");
                input = Console.ReadLine();
            }

            return int.Parse(input);
        }
    }
}
