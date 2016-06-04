using System;

namespace _02.NightmareOnCodeStreet
{
    class NightmareOnCodeStreet
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] digits = input.ToCharArray();

            long sum = 0;
            int oddDigitsCount = 0;
            for(int i = 0; i < digits.Length; i++)
            {
                if(i % 2 == 1 && Char.IsDigit(digits[i]))
                {             
                    sum += long.Parse(digits[i].ToString());
                    oddDigitsCount++;
                }
            }

            Console.WriteLine("{0} {1}", oddDigitsCount, sum);
        }
    }
}
