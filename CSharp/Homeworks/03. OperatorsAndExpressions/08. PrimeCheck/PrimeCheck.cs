using System;

namespace _08.PrimeCheck
{
    /// <summary>
    /// Write a program that reads an integer Nand uses an expression 
    /// to check if given N is prime (i.e. it is divisible without 
    /// remainder only to itself and 1).
    /// </summary>
    class PrimeCheck
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            bool isPrime = IsPrime(inputNumber);

            Console.WriteLine(isPrime);
        }

        static bool IsPrime(int number)
        {
            int boundary = (int)Math.Floor(Math.Sqrt(number));

            if (number == 1 || number <= 0 ) return false;
            if (number == 2) return true;

            for (int i = 2; i <= boundary; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
