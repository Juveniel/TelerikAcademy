using System;

namespace _04.ExRugs
{
    class ExRugs
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            int width = 2 * n + 1;

            for(int row = 0; row < n; n++)
            {
                if(n > d)
                {
                    Console.Write();
                }
            }
        }
    }
}
