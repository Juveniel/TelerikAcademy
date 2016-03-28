using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ForestRoad
{
    class ForestRoad
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = 2 * width - 1;

            char path = '*';
            char tree = '.';
            
            for(int i = 0; i < width - 1; i++)
            {               
                Console.Write(new string(tree, i));
                Console.Write(new string(path, 1));
                Console.Write(new string(tree, width - i - 1));
                Console.WriteLine();
            }

            for (int i = width - 1; i >= 0; i--)
            {
                Console.Write(new string(tree, i));
                Console.Write(new string(path, 1));
                Console.Write(new string(tree, width - i - 1));
                Console.WriteLine();
            }

        }
    }
}
