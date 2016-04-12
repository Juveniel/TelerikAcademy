using System;
using System.Collections.Generic;
using System.Numerics;

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

        static BigInteger TransformNumber(BigInteger num)
        {
            List<long> productSums = new List<long>();

            while (num.ToString().Length > 1)
            {
                num /= 10;
                productSums.Add(FindEvenPositionsSum(long.Parse(num.ToString())));
            }
            iterationsCount++;

            BigInteger product = GetProductOfSums(productSums);
            var productDigits = GetDigitsCount(product);

            if (productDigits == 1 && iterationsCount < 10)
            {
                Console.WriteLine(iterationsCount);
                Console.WriteLine(product);
            }
            else if (productDigits > 1 && iterationsCount < 10)
            {
                BigInteger newNum = product;
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
            int counter = 0;
            long sum = 0;
            long x = 0;

            long[] digitsArr = new long[input.ToString().Length];
            while (input > 0)
            {

                x = input % 10;
                digitsArr[counter] = x;

                input = input / 10;
                counter++;
            }

            Array.Reverse(digitsArr);
            for(int i = 0; i < digitsArr.Length; i++)
            {
                if(i % 2 == 0)
                {
                    sum += digitsArr[i];
                }
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

        static int GetDigitsCount(BigInteger num)
        {
            return num.ToString().Length;
        }
    }
}