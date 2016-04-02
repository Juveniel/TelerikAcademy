using System;

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
            int upperBoundary = int.Parse(Console.ReadLine());

            PrintFibonacciSequence(upperBoundary);
        }      

        public static void PrintFibonacciSequence(int n)
        {        
            int a = 0;
            int b = 1;   

            if(n == 1)
            {
                Console.WriteLine(0);
                return;
            }

            Console.Write(a + " " + b + " ");

            for (int i = 2; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + a;
                Console.Write(b + " ");
            }

            Console.WriteLine();         
        }
    }
}
