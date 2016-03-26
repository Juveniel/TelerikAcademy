using System;

namespace _04.CheckThirdBit
{
    class CheckThirdBit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your number: ");
            int inputNum = int.Parse(Console.ReadLine());

            var binaryRep = Convert.ToString(inputNum, 2);

            int mask = inputNum >> 2;
            int result = inputNum & mask;
            int bit = 1 & mask;

            Console.WriteLine("The third bit of your number is: {0}", bit);
        }
    }
}
