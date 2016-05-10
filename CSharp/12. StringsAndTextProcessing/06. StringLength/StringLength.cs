using System;
using System.Text;

namespace _06.StringLength
{
    /// <summary>
    /// Write a program that reads from the console a string of maximum 20 characters.
    /// If the length of the string is less than 20, the rest of the characters should
    /// be filled with *.
    /// </summary>
    class StringLength
    {
        static void Main(string[] args)
        {          
            string input = Console.ReadLine();
            
            if (input.Length < 20)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(input).Append('*', 20 - input.Length);
                input = sb.ToString();
            }

            Console.WriteLine(input);
        }
    }
}
