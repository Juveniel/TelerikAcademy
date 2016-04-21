using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.PersianRugsVariant3
{
    class PersianRugsVariant3
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            int width = 2 * n + 1;

            for(int row = 0; row < n; row++)
            {                                                     
                Console.Write(new string('#', row));
                Console.Write("\\");            
                int spaceLeft = width - row - row - 1 - 1 - d - d;
                if(spaceLeft >= 2)
                {
                    Console.Write(new string(' ', d));
                    Console.Write('\\');
                    Console.Write(new string(' ', spaceLeft));
                    Console.Write('/');
                    Console.Write(new string(' ', d));
                }               
                Console.Write("/");
                Console.Write(new string('#', row));

             

                Console.WriteLine();
            }

            Console.WriteLine(new string('#' , n) + "X" + new string('#', n));

            for(int rowb = n - 1; rowb >= 0; rowb--)
            {
                Console.Write(new string('#', rowb));
                Console.Write("/");
                Console.Write(new string(' ', width - (rowb * 2) - 2));
                Console.Write("\\");
                Console.Write(new string('#', rowb));

                Console.WriteLine();
            }
        }
    }
}
