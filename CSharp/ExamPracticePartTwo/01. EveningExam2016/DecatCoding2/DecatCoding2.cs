using System;
using System.Linq;

namespace DecatCoding2
{
    class DecatCoding2
    {
        static long CatToDec(string catNumber)
        {
            long result = 0;

            foreach (char digit in catNumber)
            {
                result = (digit - 'a') + result * 21;
            }

            return result;
        }   
        
        static string DecTo26(long dec)
        {
            var result = string.Empty;

            do
            {
                char digitValue = (char)('a' + (dec % 26));
                result = digitValue + result;

                dec /= 26;
            } while (dec > 0);
             
            return result;   
        }     

        static void Main()
        {
            var catNumbers = Console.ReadLine()
                .Split(' ')
                .Select(CatToDec)
                .Select(DecTo26).ToArray();

            Console.WriteLine(string.Join(" ", catNumbers));
        }
    }
}
