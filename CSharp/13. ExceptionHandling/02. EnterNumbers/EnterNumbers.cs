using System;

namespace _02.EnterNumbers
{
    /// <summary>
    /// Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end]. 
    /// If an invalid number or non-number text is entered, the method should throw an exception.
    /// </summary>
    class EnterNumbers
    {
        static void Main()
        {
            int min = 1;
            int max = 100;
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Enter a number in the range of [ {0} , {1} ]", min, max);
                    max = ReadNumber(min, max);
                }

            }
            catch (FormatException fe)
            {
                Console.WriteLine(fe.Message);
            }
            catch (ArgumentOutOfRangeException oe)
            {
                Console.WriteLine(oe.Message);
            }
            catch (ArgumentException argEx)
            {
                Console.WriteLine(argEx.Message);
            }           
        }

        private static int ReadNumber(int start, int end)
        {
            if (start > end)
            {
                throw new ArgumentException("Start is bigger than end!");
            }
            int firstNumber = int.Parse(Console.ReadLine());
            if (firstNumber > end || firstNumber < start)
            {
                throw new ArgumentOutOfRangeException();
            }
            return firstNumber;
        }
    }
}
