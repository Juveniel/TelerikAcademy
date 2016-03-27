using System;

namespace _05.FibonacciSequencePrint
{
    class FibonacciSequencePrint
    {
        /// <summary>
        /// Write a program that reads from the console number N and prints
        /// the sum of the first N members of the fibonacci sequence.
        /// </summary>

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of n: ");
            int n = int.Parse(Console.ReadLine());

            PrintFibonacciSequenceSum(n);
        }

        public static void PrintFibonacciSequenceSum(int n)
        {
            int a = 0;
            int b = 1;                  
            int sequenceSum = 1;

            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + a;

                sequenceSum += b;
                Console.Write(b + " ");
            }

            Console.WriteLine("The sum of the sequence is: {0}", sequenceSum);
        }
    }
}
