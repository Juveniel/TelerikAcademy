using System;

namespace _02.TheHorror
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] digits = input.ToCharArray();

            int evenPositionsCount = 0;
            long evenPositionsSum = 0;
            for (int i = 0; i < digits.Length; i++)
            {
                if (i % 2 == 0 && Char.IsDigit(digits[i]))
                {
                    evenPositionsSum += long.Parse(digits[i].ToString());
                    evenPositionsCount++;
                }
            }

            Console.Write("{0} {1}", evenPositionsCount, evenPositionsSum);
            Console.WriteLine();
        }
    }
}
