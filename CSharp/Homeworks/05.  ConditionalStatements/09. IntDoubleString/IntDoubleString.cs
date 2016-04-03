using System;

namespace _09.IntDoubleString
{
    /// <summary>
    /// Write a program that, depending on the first line of the input, 
    /// reads an int, double or string variable.
    /// If the variable is int or double, the program increases it by one.
    /// If the variable is a string, the program appends * at the end.
    /// Print the result at the console. Use switch statement.
    /// </summary>
    class IntDoubleString
    {
        static void Main(string[] args)
        {
            string userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "integer":
                    int intInput = int.Parse(Console.ReadLine());
                    Console.WriteLine(intInput + 1);
                    break;
                case "real":
                    double doubleInput = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:F2}", doubleInput + 1L);
                    break;
                case "text":
                    string strInput = Console.ReadLine();
                    Console.WriteLine(strInput + "*");
                    break;
                default:
                    Console.WriteLine("invalid type");
                    break;
            }
        }
    }
}
