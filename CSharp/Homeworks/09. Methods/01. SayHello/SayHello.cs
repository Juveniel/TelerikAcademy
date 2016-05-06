using System;

namespace _01.SayHello
{
    /// <summary>
    /// Write a method that asks the user for his name and prints 
    /// Hello, <name>!. Write a program to test this method.
    /// </summary>
    public class SayHello
    {
        internal static void Main()
        {
            string name = Console.ReadLine();
            Console.WriteLine(GreetPerson(name)); 
        }

        public static string GreetPerson(string name)
        {
            string greeting = "Hello, " + name + "!";

            return greeting;
        }
    }
}
