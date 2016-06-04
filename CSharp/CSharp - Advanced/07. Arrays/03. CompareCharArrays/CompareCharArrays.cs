using System;
using System.Collections.Generic;

namespace _03.CompareCharArrays
{
    /// <summary>
    /// Write a program that compares two char arrays lexicographically (letter by letter).
    /// </summary>
    class CompareCharArrays
    {
        static void Main(string[] args)
        {
            string firstInput = Console.ReadLine();
            string secondInput = Console.ReadLine();

            CompareLexicographically(firstInput, secondInput);              
        }

        static void CompareLexicographically(string first, string second)
        {
            string result = "";


            if (first.Length < second.Length)
            {
                Console.WriteLine("<");
            }
            else if(first.Length > second.Length)
            {
                Console.WriteLine(">");
            }
            else if(first.Length == second.Length)
            {
                for (int i = 0; i < first.Length; i++)
                {
                    if (first[i] != second[i])
                    {
                        if (first[i] < second[i])
                        {
                            result = "<";
                        }
                        else
                        {
                            result = ">";
                        }

                        break;
                    }
                    else
                    {
                        result = "=";
                    }
                }

                Console.WriteLine(result);
            }      
        }
    }

  
}
