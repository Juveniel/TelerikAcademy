using System;

namespace TRES4Numbers
{
    class TRES4Numbers
    {               
        static void Main()
        {
            string[] tres4Numbers = new string[] { "LON+", "VK-", "*ACAD", "^MIM", "ERIK|", "SEY&", "EMY>>", "/TEL", "<<DON" };

            ulong number = ulong.Parse(Console.ReadLine());
            int[] digits = new int[32];
            int digitsCount = 0;

            do
            {
                digits[digitsCount] = (int)(number % 9);
                number /= 9;
                digitsCount++;
            }
            while (number > 0);
         
            
            for (int i = digitsCount - 1; i >= 0; i--)
            {

                Console.Write(tres4Numbers[digits[i]]);
            }

            Console.WriteLine();
        }
    }
}
