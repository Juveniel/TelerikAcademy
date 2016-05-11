using System;
using System.Text;
using System.Collections.Generic;

namespace _02.DecatCoding
{
    class DecatCoding
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ');



            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < words.Length; i++)
            {
                string currentWord = words[i];

                // sb.Append(ConvertWordToBase26(currentWord));
                Console.WriteLine(ConvertWordToBase26(currentWord));
            }
           // Console.WriteLine(sb.ToString());
        }

        private static int ConvertCharToInt(char letter)
        {
            return  char.ToUpper(letter) - 65;
        }

        private static char IntToLetter(int num)
        {
            return Convert.ToChar(num);
        }

        private static string ConvertWordToBase26(string word)
        {  
            StringBuilder sb = new StringBuilder();
            int base21 = 0;

            for(int i = 0; i < word.Length; i++)
            {
                char currentLetter = word[i];
                int currentLEtterIdx = ConvertCharToInt(currentLetter);
                int power = word.Length - i - 1;
                double based = Math.Pow(21D, power);
   
                //Console.WriteLine(currentLetter + " " + currentLEtterIdx + " " + based + " " + (based ));
                base21 += currentLEtterIdx * (int)based;
            }

            for (int j = 0; j < word.Length; j++)
            {
                Console.WriteLine((base21 % 26)); 

                base21 %= 26;
            }

            return sb.ToString();
        }
    }
}
