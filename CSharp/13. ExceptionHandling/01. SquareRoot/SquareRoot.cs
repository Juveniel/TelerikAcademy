using System;

namespace _01.SquareRoot
{
    /// <summary>
    /// Write a program that reads an integer number and calculates and prints its square root. 
    /// </summary>
    class SquareRoot
    {
        static void Main(string[] args)
        {
            try
            {
                int num = int.Parse(Console.ReadLine());
                if (num < 0)
                {
                    throw new FormatException();
                }
                Console.WriteLine(Math.Sqrt(num));
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Invalid number: {0}", fe.Message);
            }
            catch (OverflowException)
            {
                Console.WriteLine("Number was too large or too small!");
            }
            finally
            {
                Console.WriteLine("Good bye!");
            }
        }
    }
}
