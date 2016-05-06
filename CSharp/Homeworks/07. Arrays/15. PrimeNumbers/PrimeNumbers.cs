using System;
using System.Collections.Generic;
using System.Linq;

namespace _15.PrimeNumbers
{
    /// <summary>
    /// Write a program that finds all prime numbers in the range [1 ... N]. 
    /// Use the Sieve of Eratosthenes algorithm. The program should print 
    /// the biggest prime number which is < N
    /// </summary>
    class PrimeNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            FindMaxPrime(n);
        }

        public static void FindMaxPrime(int n)
        {
            List<int> primes = new List<int>();
            bool[] isComposite = new bool[n + 1];

            for (int x = 2; x * x <= n; x++)
            {
                if (!isComposite[x])
                {
                    for (int y = x * x; y <= n; y = y + x)
                    {
                        isComposite[y] = true;
                    }
                }
            }

            for (int i = 2; i < isComposite.Length; i++)
            {
                if (isComposite[i] == false)
                {
                    primes.Add(i);
                }
            }

            Console.WriteLine(primes.Max());
        }
    }
}
