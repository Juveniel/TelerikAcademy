using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _01.CalculationProblem
{
    class CalculationProblem
    {
        private static List<int> decimalSumsList = new List<int>();

        static void Main()
        {
            string input = Console.ReadLine();
            string[] words = input.Split(' ');

            PrintSums(words);
        }

        public static int ConvertWordToDecimal(string word)
        {
            StringBuilder sb = new StringBuilder();
            int poweredNum = 0;

            for(int i = 0; i < word.Length; i++)
            {
                int letterIdx = (int)char.ToUpper(word[i]) - 65;
                poweredNum += letterIdx * (int)Math.Pow(23D, word.Length - i - 1);                
            }

            return poweredNum;
        }  
             

        public static void PrintSums(string[] words)
        {                     
            int decimalSum = 0;

            foreach (var word in words)
            {
                decimalSum += ConvertWordToDecimal(word);
            }

            Console.WriteLine("{0} = {1}", DecimalToAny(23, decimalSum), decimalSum);
        }

        public static string DecimalToAny(int d, int decimalResult)
        {
            string result = string.Empty;
            if (decimalResult == 0) result = "0";
            while (decimalResult > 0)
            {

                int remainder = decimalResult % d;

                result += (char)((remainder + 97));

                decimalResult /= d;

            }
            var reverseResult = result.ToCharArray().Reverse();
            return string.Join("", reverseResult);
        }
    }
}
