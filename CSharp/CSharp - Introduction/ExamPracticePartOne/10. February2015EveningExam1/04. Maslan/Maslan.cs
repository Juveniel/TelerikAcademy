using System;
using System.Numerics;

namespace _04.Maslan
{
    class Maslan
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            int transformationsCount = 0;
            bool finished = false;

            while (n.Length > 1)
            {
                BigInteger numTransformed = 1;
                int sum = 0;

                char[] digits = n.ToCharArray();
                for (int i = 0; i < digits.Length; i++)
                {
                    if (i % 2 != 0)
                    {
                        sum += int.Parse(digits[i].ToString());
                    }

                    if (sum > 0)
                    {
                        numTransformed *= sum;
                    }
                }

                if (sum != 0)
                {
                    numTransformed /= sum;
                }

                transformationsCount++;

                n = numTransformed.ToString();

                if (transformationsCount == 10)
                {
                    finished = true;
                    break;
                }
            }

            if (finished)
            {
                Console.WriteLine(n);
            }
            else
            {
                Console.WriteLine(transformationsCount);
                Console.WriteLine(n);
            }  
        }   
    }
}
