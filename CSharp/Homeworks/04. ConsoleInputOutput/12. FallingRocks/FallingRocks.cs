using System;
using System.Collections.Generic;
using System.Threading;

class FallingRocks
{
    private static Random randomGenerator = new Random();
    static char[] rockSymbols = { '^', '@', '*', '&', '$', '+', '!', '#', '%', '.', ';' };
    static int playField = 18;

    struct Object
    {
        public int x;
        public int y;
        public string c;
        public ConsoleColor color;
    }

    static void PrintOnPosition(int x, int y, char c, ConsoleColor color = ConsoleColor.Gray)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(c);
    }

    static void Printer(int x, int y, string s, ConsoleColor color = ConsoleColor.Gray)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(s);
    }

    private static ConsoleColor GetRandomConsoleColor()
    {
        var consoleColors = Enum.GetValues(typeof(ConsoleColor));
        return (ConsoleColor)consoleColors.GetValue(randomGenerator.Next(consoleColors.Length));
    }

    static void Main()
    {
        Console.BufferWidth = Console.WindowWidth = 40;
        Console.BufferHeight = Console.WindowHeight = 20;

        Object dwarf = new Object();
        dwarf.x = Console.WindowWidth / 2 - 1;
        dwarf.y = Console.WindowHeight - 1;
        dwarf.c = "(0)";
        dwarf.color = ConsoleColor.White;

        List<Object> rocks = new List<Object>();
        int livesCount = 5;
        int score = 0;


        Console.WriteLine("Welcome to Falling Rocks!");
        Console.WriteLine();
        Console.WriteLine("You are a dwarf \"(O)\" , who's job is to avoid getting" +
        " hit by the falling rocks \n from the top!");
        Console.WriteLine();
        Console.WriteLine("Press [enter] to begin.");
        Console.ReadLine();

        while (true)
        {

            Object firstLineRocks = new Object();
            firstLineRocks.x = randomGenerator.Next(0, playField);
            firstLineRocks.y = 0;
            firstLineRocks.c = rockSymbols[randomGenerator.Next(1, 10)].ToString();
            firstLineRocks.color = GetRandomConsoleColor();
            rocks.Add(firstLineRocks);

            List<Object> newList = new List<Object>();
            for (int i = 0; i < rocks.Count; i++)
            {
                Object oldRock = rocks[i];
                Object newRock = new Object();
                newRock.x = oldRock.x;
                newRock.y = oldRock.y + 1;
                newRock.c = oldRock.c;
                newRock.color = oldRock.color;

                if (newRock.x == dwarf.x + 2 && newRock.y == dwarf.y)
                {
                    livesCount--;
                }
                if (newRock.x == dwarf.x + 1 && newRock.y == dwarf.y)
                {
                    livesCount--;
                }
                if (newRock.x == dwarf.x && newRock.y == dwarf.y)
                {
                    livesCount--;
                }
                if (newRock.y < Console.WindowHeight)
                {
                    newList.Add(newRock);
                }

                if (livesCount <= 0)
                {
                    Console.Clear();
                    Printer(13, 10, "GAME OVER !", ConsoleColor.Red);
                    Printer(7, 12, "Your score is: !" + score, ConsoleColor.Red);
                    Printer(7, 14, "Press [enter] to exit ", ConsoleColor.White);
                    Console.ReadLine();
                    Environment.Exit(0);
                }

            }
            rocks = newList;

            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                while (Console.KeyAvailable) Console.ReadKey(true);
                if (pressedKey.Key == ConsoleKey.LeftArrow)
                {
                    if (dwarf.x - 1 >= 0)
                    {
                        dwarf.x = dwarf.x - 1;
                    }
                }
                if (pressedKey.Key == ConsoleKey.RightArrow)
                {
                    if (dwarf.x + 1 < playField)
                    {
                        dwarf.x = dwarf.x + 1;
                    }
                }
            }

            Printer(dwarf.x, dwarf.y, dwarf.c, dwarf.color);

            foreach (Object rock in rocks)
            {
                Printer(rock.x, rock.y, rock.c, rock.color);
            }
            Printer(24, 2, "LIVES: " + livesCount, ConsoleColor.White);
            Printer(24, 4, "SCORE: " + score, ConsoleColor.White);

            score++;
            Thread.Sleep(250);
            Console.Clear();
        }
    }
}

