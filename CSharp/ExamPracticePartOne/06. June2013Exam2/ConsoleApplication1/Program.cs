using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            long numEntered = int.Parse(Console.ReadLine());
            string array = Convert.ToString(numEntered, 2);

            Console.WriteLine(array[array.Length - 3]);
        }
    }
}
