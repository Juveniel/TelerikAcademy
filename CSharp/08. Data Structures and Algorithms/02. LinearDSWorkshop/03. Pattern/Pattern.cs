using System;
using System.Text;

namespace _03.Pattern
{
    public class Pattern
    {
        private static string figure = "urd";

        private static void Main()
        {
            var input = int.Parse(Console.ReadLine());
            PrintFigure(input - 1);
        }

        public static void PrintFigure(int iterations)
        {
            if (iterations == 0)
            {
                Console.WriteLine(figure);
                Environment.Exit(0);
            }

            var nextFigure = new StringBuilder();


            for (var i = figure.Length - 1; i >= 0; i--)
            {
                var letter = figure[i];
                nextFigure.Append(RotateRight(letter.ToString()));
            }


            nextFigure.Append("u");


            nextFigure.Append(figure);


            nextFigure.Append("r");


            nextFigure.Append(figure);


            nextFigure.Append("d");


            for (var i = figure.Length - 1; i >= 0; i--)
            {
                var letter = figure[i];
                nextFigure.Append(RotateLeft(letter.ToString()));
            }

            figure = nextFigure.ToString();

            PrintFigure(iterations - 1);
        }

        private static string RotateLeft(string letter)
        {
            switch (letter)
            {
                case "u":
                    return "r";
                case "r":
                    return "d";
                case "d":
                    return "l";
                case "l":
                    return "u";
                default:
                    throw new ArgumentException();
            }
        }

        private static string RotateRight(string letter)
        {
            switch (letter)
            {
                case "u":
                    return "l";
                case "r":
                    return "u";
                case "d":
                    return "r";
                case "l":
                    return "d";
                default:
                    throw new ArgumentException();
            }
        }
    }
}
