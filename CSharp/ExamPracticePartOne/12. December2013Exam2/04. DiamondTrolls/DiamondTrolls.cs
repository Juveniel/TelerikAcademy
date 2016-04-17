using System;

namespace _04.DiamondTrolls
{
    class DiamondTrolls
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = n * 2 + 1;
            int height = (6 + ((n -3) / 2) * 3);

            int innerHeight = height - n - 2;
            int innerDots = ((width - innerHeight * 2) - 3) / 2;
 
            Console.WriteLine(" " + new string('.', innerHeight + 1) + new string('*', width - 2 * innerHeight - 2) + new string('.', innerHeight + 1));
            for(int i = 0; i < height - n - 2; i++)
            {
                Console.WriteLine(" " + new string('.', innerHeight) + "*" + new string('.', innerDots) + "*" + new string('.', innerDots) + "*" + new string('.', innerHeight));

                innerHeight--;
                innerDots++;
            }
            Console.WriteLine(" " + new string('*', width));

            int bottomDots = innerDots - 1;
            int bottomDotsOuter = 1;
            for(int j = 0; j < n - 1; j++)
            {
                Console.WriteLine(" " + new string('.', bottomDotsOuter) + "*" + new string('.', bottomDots) + "*" + new string('.', bottomDots) + "*" + new string('.', bottomDotsOuter));
         
                bottomDots--;                  
                bottomDotsOuter++;
            }
            Console.WriteLine(" " + new string('.',width - n - 1) + "*" + new string('.', width - n - 1));
        }
    }
}
