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
                double num = double.Parse(Console.ReadLine());
                if (num < 0)
                {
                    throw new FormatException("Invalid number");
                }
                Console.WriteLine("{0:F3}", Math.Sqrt(num));
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Argument was null!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Number was too large or too small!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}
