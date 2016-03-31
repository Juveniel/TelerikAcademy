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

            for (char c = (char)033; c <= (char)255; c++)
            {
                Console.WriteLine(c);
            }
        }
    }
}
