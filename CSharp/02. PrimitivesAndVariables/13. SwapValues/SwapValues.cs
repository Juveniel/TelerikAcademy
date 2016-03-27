using System;

namespace _13.SwapValues
{
    /// <summary>
    /// Declate two variables of type int and swap their values.
    /// </summary>
    class SwapValues
    {
        static void Main(string[] args)
        {
            int firstNum = 5;
            int secondNum = 10;  
                 
            firstNum = secondNum;
       
            Console.WriteLine("First number = {0} and second number = {1}", firstNum, secondNum);
        }
    }
}
