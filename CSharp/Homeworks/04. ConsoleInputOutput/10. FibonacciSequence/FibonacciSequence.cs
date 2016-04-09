using System;
using System.Numerics;

namespace _10.FibonacciSequence
{
    /// <summary>
    /// Write a program that reads a number N and prints on the console the
    /// first N members of the Fibonacci sequence
    /// </summary>
    class FibonacciSequence
    {
        static void Main(string[] args)
        {
            BigInteger upperBoundary = BigInteger.Parse(Console.ReadLine());

            PrintFibonacciSequence(upperBoundary);
        }      

        public static void PrintFibonacciSequence(BigInteger n)
        {
            BigInteger a = 0;
            BigInteger b = 1;   

            if(n == 1)
            {
                Console.WriteLine(0);
                return;
            }

            if(n == 2 || n == 0)
            {
                Console.Write(a + ", " + b);
            }
            else
            {
                Console.Write(a + ", " + b + ", ");
            }
          
            for (BigInteger i = 2; i < n; i++)
            {
                BigInteger temp = a;
                a = b;
                b = temp + a;

                if(i == (n - 1))
                {
                    Console.WriteLine(b);
                }
                else
                {
                    Console.Write(b + ", ");
                }                
            }

            Console.WriteLine();         
        }
    }
}
