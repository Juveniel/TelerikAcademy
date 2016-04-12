using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.SaddyKopper
{
    class SaddyKopper
    {     
        static int iterationsCount = 0;

        static void Main(string[] args)
        {       
            long input = long.Parse(Console.ReadLine());
            TransformNumber(input);
        }

        static long TransformNumber(long num)
        {
            List<long> productSums = new List<long>();

            while (num.ToString().Length > 1)
            {
                num /= 10;
                productSums.Add(FindEvenPositionsSum(long.Parse(num.ToString())));     
            }
            iterationsCount++;

            long product = GetProductOfSums(productSums);            
            int productDigits = GetDigitsCount(product);        

            if (productDigits == 1 && iterationsCount < 10)
            {
                Console.WriteLine(iterationsCount);
                Console.WriteLine(product);
            }
            else if (productDigits > 1 && iterationsCount < 10)
            {
                long newNum = product;
                product = TransformNumber(newNum);              
            }
            else
            {
                Console.WriteLine(product);                
            }

            return product;
        }

        static long FindEvenPositionsSum(long input)
        {
            long sum = 0;
            /*  char[] inputPositions = input.ToString().ToCharArray();

               for (int i = 0; i < inputPositions.Length; i++)
               {
                   if(i % 2 == 0)
                   {
                       sum += int.Parse(inputPositions[i].ToString());
                   }
               }     */
         

            while(input != 0)
            {
                if(input % 2 == 0)
                {
                    sum += input;
                }

                input /= 10;
            }

            return sum;
        }

        static long GetProductOfSums(List<long> numbers)
        {
            long prod = 1;
            foreach (int value in numbers)
            {
                prod *= value;
            }

            return prod;
        }

        static int GetDigitsCount(long num)
        {
            int length = num.ToString().Length;

            return length;
        }
    }
}
