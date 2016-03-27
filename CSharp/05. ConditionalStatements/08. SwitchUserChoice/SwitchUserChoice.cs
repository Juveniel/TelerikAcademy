using System;

namespace _08.SwitchUserChoice
{
    /// <summary>
    ///  Write a program that, depending on the user’s choice, inputs int, double 
    ///  or string variable. If the variable is int or double, the program 
    ///  increases it by 1. If the variable is a string, the program appends "*" 
    ///  at the end. Print the result at the console. Use switch statement.
    /// </summary>
    class SwitchUserChoice
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a variable type: ");
            Console.WriteLine("1. int");
            Console.WriteLine("2. double");
            Console.WriteLine("3. string");

            int userChoice = int.Parse(Console.ReadKey().KeyChar.ToString());
            Console.WriteLine();
         
            switch (userChoice)
            {
                case 1:                    
                    int intInput = int.Parse(Console.ReadLine());
                    Console.WriteLine(intInput + 1);
                    break;
                case 2:
                    double doubleInput = double.Parse(Console.ReadLine());
                    Console.WriteLine(doubleInput + 1L);
                    break;
                case 3:
                    string strInput = Console.ReadLine();
                    Console.WriteLine(strInput + "*");
                    break;
            }
                        
        }
    }
}
