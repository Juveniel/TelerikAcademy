using System;

namespace _11.PrintFirstNFibonacciNumbers
{
    class PrintFirstNFibonacciNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number for upper boundary: ");
            int upperBoundary = CheckInputFormat(Console.ReadLine());

            PrintFibonacciSequence(upperBoundary);
        }

        static int CheckInputFormat(string input)
        {
            int result;
            while (!int.TryParse(input, out result))
            {
                Console.WriteLine("Please try again with a correct number: ");
                input = Console.ReadLine();
            }

            return int.Parse(input);
        }

        public static void PrintFibonacciSequence(int n)
        {
            int a = 0;
            int b = 1;
            Console.Write(a + " " + b + " ");

            for(int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + a;
                Console.Write(b + " ");
            }
        }
    }
}
