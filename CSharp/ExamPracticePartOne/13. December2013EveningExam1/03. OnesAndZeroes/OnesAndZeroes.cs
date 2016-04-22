using System;

namespace _03.OnesAndZeroes
{
    class OnesAndZeroes
    {
        static string[] zero = new string[] { "###", "#.#", "#.#", "#.#", "###" };
        static string[] one = new string[] { ".#.", "##.", ".#.", ".#.", "###" };

        static void Main(string[] args)
        {
            uint n = uint.Parse(Console.ReadLine());
            string nBinary = Convert.ToString(n, 2).PadLeft(16, '0');
            nBinary = nBinary.Length < 16 ? nBinary.PadLeft(16, '0') : nBinary.Substring(nBinary.Length - 16);

            char[] digits = nBinary.ToCharArray();

            for (int i = 0; i < zero.Length; i++)
            {
                for(int j = 0; j < digits.Length; j++)
                {                  

                    if (digits[j] % 2 == 0)
                    {
                        Console.Write(zero[i]);                        
                    }
                    else
                    {
                        Console.Write(one[i]);
                    }

                    Console.Write((j < digits.Length - 1) ? "." : "");

                }               
                Console.WriteLine();
            }          
        }
    }
}
