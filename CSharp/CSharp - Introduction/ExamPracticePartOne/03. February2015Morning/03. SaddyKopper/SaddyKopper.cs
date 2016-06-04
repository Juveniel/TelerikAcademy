using System;
using System.Numerics;

namespace _03.SaddyKopper
{
    class SaddyKopper
    {
        static int iterationsCount = 0;

        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int transofrmationsCount = 0;

           
            while(input.Length > 1 && transofrmationsCount < 10)
            {
                BigInteger product = 1;
                while (input.Length > 1)
                {
                    input = input.Substring(0, input.Length - 1);
                    int sum = 0;
                    for (int i = 0; i < input.Length; i += 2)
                    {
                        sum += (input[i] - '0');
                    }

                    if (sum != null)
                    {
                        product *= sum;
                    }
                    else
                    {
                        product = 1;
                    }
                }

                transofrmationsCount++;
                input = product.ToString();
            }
                      
            if(transofrmationsCount < 10)
            {
                Console.WriteLine(transofrmationsCount);
            }

            Console.WriteLine(input);
        }      
    }
}