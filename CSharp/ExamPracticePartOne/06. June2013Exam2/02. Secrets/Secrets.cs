using System;
using System.Numerics;
using System.Linq;

namespace _02.Secrets
{
    class Secrets
    {
        static void Main(string[] args)
        {
            BigInteger input = BigInteger.Parse(Console.ReadLine());
            if (input < 0)
            {
                input = -input;
            }

            char[] inputDigits = input.ToString().ToArray();
            Array.Reverse(inputDigits);      

            int specialSum = 0;
            int counter = 1;
      
            foreach(char digit in inputDigits)
            {

                int digitInt = int.Parse(digit.ToString());

                if (counter % 2 == 0)
                {
                    specialSum += (digitInt * digitInt * counter);
                }
                else
                {                        
                    specialSum += (digitInt * counter * counter);
                }

                counter++;
            }
        
            Console.WriteLine(specialSum);

            if(specialSum % 10 == 0)
            {
                Console.WriteLine("{0} has no secret alpha-sequence", input);
            }


            int r = specialSum % 26;
            int sequenceCount = specialSum % 10;

            for(int i = 0; i < sequenceCount; i++)
            {
                Console.Write("{0}", GetColumnName(r + i));
            }
            Console.WriteLine();

        }

        static string GetColumnName(int index)
        {
            const string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            var value = letters[index % letters.Length].ToString();

            return value;
        }
    }
}
