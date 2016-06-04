using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Enigmanation
{
    class Enigmanation
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();

            string firsteQ = getBetween(expression, "(", ")");

            Console.WriteLine(firsteQ);
        }

        static string getBetween(string strSource, string strStart, string strEnd)
        {
            int Start, End;
            if (strSource.Contains(strStart) && strSource.Contains(strEnd))
            {
                Start = strSource.IndexOf(strStart, 0) + strStart.Length;
                End = strSource.IndexOf(strEnd, Start);
                return strSource.Substring(Start, End - Start);
            }
            else
            {
                return "";
            }
        }

        static int SolveEquation(string eq)
        {
        
        }
    }
}
