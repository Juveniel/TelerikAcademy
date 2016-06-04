using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.SolveTasks
{
    /// <summary>
    /// Write a program that can solve these tasks:
    /// * Reverses the digits of a number
    /// * Calculates the average of a sequence of integers
    /// * Solves a linear equation a* x + b = 0 
    /// </summary>
    class SolveTasks
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program menu");
            Console.WriteLine("1. Reverse the digits of a number");
            Console.WriteLine("2. Calculate the average for a set of numbers");
            Console.WriteLine("3. Solve a linear equation a * x  + b = 0");

            int userChoice = int.Parse(Console.ReadLine());
            if(userChoice == 1)
            {
                Console.WriteLine("Please enter the number you would like to reverse: ");
                int number = int.Parse(Console.ReadLine());

                int numberReversed = ReverseDigits(number);
                Console.WriteLine(numberReversed);
            }
            else if(userChoice == 2)
            {
                Console.WriteLine("Please enter the numbers from your set separated by a white space: ");
                string[] inputLine = Console.ReadLine().Split(' ');
                int[] userSet = FillArray(inputLine);

                int averageOfTheSet = CalculateAverageOfSet(userSet);
                Console.WriteLine(averageOfTheSet);
            }
            else if(userChoice == 3)
            {
                Console.WriteLine("Please enter the value of a: ");
                decimal a = decimal.Parse(Console.ReadLine());
                decimal b = decimal.Parse(Console.ReadLine());

                decimal result = SolveLinearEquation(a, b);

                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Invalid operation !");
            }
        }

        private static int ReverseDigits(int num)
        {
            int result = 0;
            while (num > 0)
            {
                result = result * 10 + num % 10;
                num /= 10;
            }
            return result;
        } 

        private static int CalculateAverageOfSet(int[] numbers)
        {
            int average = 0;
            int total = 0;

            for(int i = 0; i < numbers.Length; i++)
            {
                total += numbers[i];
            }

            average = total / numbers.Length;

            return average;
        }

        private static decimal SolveLinearEquation(decimal a, decimal b)
        {       
            decimal x = -(b / a);

            return x;
        }   
        
        private static int[] FillArray(string[] input)
        {
            int[] numbersArr = new int[input.Length];
            for(int i = 0; i < input.Length; i++)
            {
                numbersArr[i] = int.Parse(input[i]);
            }

            return numbersArr;
        }
    }
}
