using System;

namespace _04.FireInTheMatrix
{
    class FireInTheMatrix
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(new string('.', (n / 2) - 1) + "##" + new string('.', (n / 2) - 1));

            var dotsCount = 2;
            var innerDots = n - 2;
            var outerDots = (n / 2) - 2;

            //fire
            for (int i = 0; i < (n / 2) - 1; i++)
            {                
                Console.WriteLine(new string('.', outerDots) + "#" + new string('.', dotsCount) + "#" + new string('.', outerDots));

                dotsCount += 2;
                outerDots--;
            }

            for(int j = 0; j < n / 4; j++)
            {
                Console.WriteLine(new string('.', j) + "#" + new string('.', innerDots) + "#" + new string('.', j));

                innerDots -= 2;
            }

            Console.WriteLine(new string('-', n)); 

            //handle
            var handleHeight = n / 2;
            var charLenght = n / 2;
            for(int i = 0; i < handleHeight; i++)
            {
                Console.WriteLine(new string('.', i) + new string('\\', charLenght) + new string('/', charLenght) + new string('.', i));

                charLenght--;
            }
        }
    }
}
