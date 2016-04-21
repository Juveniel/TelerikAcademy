using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.PersianRugsVariant2
{
    class PersianRugsVariant2
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            int height = 2 * n + 1;


            int middleCOunt = n - 2 - (row * 2);
            for(int row = 0; row < n; row++)
            {               
                if(row == 0)
                {
                    Console.WriteLine("\\" + new string(' ', d) + "\\" + new string('.', 3) + "/" + new string(' ', d) + "/");
                }
                else if(row == 1)
                {
                    Console.WriteLine(new string('#', row) +  "\\" + new string(' ', d) + "\\" + new string('.', 1) + "/" + new string(' ', d) + "/" + new string('#', row));
                }
                else
                {
                    Console.WriteLine(new string('#', row) + "\\" + new string(' ', middleCOunt) + "/" + new string('#', row));
                }

                middleCOunt -= 2;
            }

        }
    }
}
