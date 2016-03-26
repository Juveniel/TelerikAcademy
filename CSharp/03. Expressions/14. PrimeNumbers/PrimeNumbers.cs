using System;

namespace _14.PrimeNumbers
{
    class PrimeNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number between 1 and 100");
            int inputNumber = int.Parse(Console.ReadLine());

            bool isPrime = IsPrime(inputNumber);

            Console.WriteLine("Is your number prime: {0}", isPrime);            
        }

        static bool IsPrime(int number)
        {
            int boundary = (int) Math.Floor(Math.Sqrt(number));

            if (number == 1 || number == 0) return false;
            if (number == 2) return true;
   
            for(int i = 2; i <= boundary; i++)
            {
                if(number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }               
    }
}
