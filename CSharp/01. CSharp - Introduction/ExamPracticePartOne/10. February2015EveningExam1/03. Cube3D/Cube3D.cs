using System;

namespace _03.Cube3D
{
    class Cube3D
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int height = (n * 2) - 1;

            int verticalCounter = 0;
            int whSpaceRight = n - 2;        
            Console.WriteLine( new string(':', n ) + new string(' ', whSpaceRight + 1));
            for (int i = 0; i < n - 2; i++)
            {
                Console.WriteLine(":" + new string(' ', n - 2) + ":" + new string('|', verticalCounter) + ":" + new string(' ', whSpaceRight));

                verticalCounter++;
                whSpaceRight--;
            }
            Console.WriteLine(new string(':', n) + new string('|', n - 2) + ":");


            int whSpace = 1;
            char verticalBot = '|';
            for (int j = 0; j < n - 2; j++)
            {
                if(j == n - 3)
                {
                    verticalBot = ':';
                }

                Console.WriteLine(new string(' ', whSpace) + ":" + new string('-', n - 2) + ":" + new string(verticalBot, verticalCounter - 1) + ":");
                verticalCounter--;
                whSpace++;
            }
            Console.WriteLine(new string(' ', whSpace) + new string(':', n ));
        }
    }
}
