using System;

namespace _14.PrintASCII
{
    /// <summary>
    /// Find online more information about ASCII and write a program
    /// that prints the visible characters of the ASCII table on the 
    /// console (characters from 33 to 126 including).
    /// </summary>
    class PrintASCII
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //also change console font to TrueType(Consolas)
            for (int i = 33; i <= 126; i++)
            {
                Console.Write((char)i);
            }
        }
    }
}
