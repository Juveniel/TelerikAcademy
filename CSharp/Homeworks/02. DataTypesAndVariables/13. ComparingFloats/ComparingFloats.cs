using System;

namespace _13.ComparingFloats
{
    /// <summary>
    /// Write a program that safely compares two floating-point numbers 
    /// (double) with precision eps = 0.000001.
    /// </summary>
    class ComparingFloats
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());

            var areEqual = CheckEqual(firstNum, secondNum);

            Console.WriteLine(areEqual);
        }

        static bool CheckEqual(double firstNum, double secondNum)
        {
            bool areEqual = Math.Abs(firstNum - secondNum) < 0.000001;

            return areEqual;
        }
    }
}
