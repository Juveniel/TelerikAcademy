using System;

namespace _10.PrintHeartShape
{
    class PrintHeartShape
    {
        static void Main(string[] args)
        {
            char symbol = 'o';          
            int iterationsCount = 20;
          
            string whSpace = "      ";
            string nO = new string(symbol, 8);
            for (int i = 0; i < 3; i++)
            {
                Console.Write(whSpace);
                Console.Write(nO);
                Console.Write(whSpace);
                Console.Write(whSpace);
                Console.WriteLine(nO);
                whSpace = whSpace.Remove(whSpace.Length - 2, 2);
                nO += "oooo";
            }


            for (int i = 0; i < iterationsCount; i++)
            {           
                Console.Write(new string(' ', i));
                Console.Write(symbol);

                for (int j = i + 1; j < iterationsCount; j++)
                {
                    Console.Write(new string(symbol, 2));
                }

                Console.WriteLine();                         
            }
        }
    }
}
