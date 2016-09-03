namespace Mines
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Mines
    {        
        public static void Main()
        {
            var gameCommand = string.Empty;
            char[,] gameField = CreateGameField();
            char[,] bombsField = SetupBombsField();
            var pointCounter = 0;
            var isDead = false;
            List<Score> champions = new List<Score>(6);
            var row = 0;
            var column = 0;
            var isNewGame = true;
            const int MaxScore = 35;
            var hasWon = false;

            do
            {
                if (isNewGame)
                {
                    Console.WriteLine("Let's play Minesweeper. Try your luck : )");
                    DrawGameField(gameField);
                    isNewGame = false;
                }

                Console.Write("Enter row or column : ");
                gameCommand = Console.ReadLine().Trim();

                if (gameCommand.Length >= 3)
                {
                    if (int.TryParse(gameCommand[0].ToString(), out row) &&
                        int.TryParse(gameCommand[2].ToString(), out column) &&
                        row <= gameField.GetLength(0) &&
                        column <= gameField.GetLength(1))
                    {
                        gameCommand = "turn";
                    }
                }

                switch (gameCommand)
                {
                    case "top":
                        ShowScoreboard(champions);
                        break;
                    case "restart":
                        gameField = CreateGameField();
                        bombsField = SetupBombsField();
                        DrawGameField(gameField);
                        isDead = false;
                        isNewGame = false;
                        break;
                    case "exit":
                        Console.WriteLine("Bye Bye!");
                        break;
                    case "turn":
                        if (bombsField[row, column] != '*')
                        {
                            if (bombsField[row, column] == '-')
                            {
                                MakeMove(gameField, bombsField, row, column);
                                pointCounter++;
                            }

                            if (MaxScore == pointCounter)
                            {
                                hasWon = true;
                            }
                            else
                            {
                                DrawGameField(gameField);
                            }
                        }
                        else
                        {
                            isDead = true;
                        }

                        break;
                    default:
                        Console.WriteLine("Error! Invalid Command");
                        break;
                }

                if (isDead)
                {
                    DrawGameField(bombsField);

                    Console.Write($"Hrrrrrr! Game over: {pointCounter} points.Enter your nickname: ");
                    var nickname = Console.ReadLine();

                    var currentPlayerScore = new Score(nickname, pointCounter);
                    if (champions.Count < 5)
                    {
                        champions.Add(currentPlayerScore);
                    }
                    else
                    {
                        for (var i = 0; i < champions.Count; i++)
                        {
                            if (champions[i].Points < currentPlayerScore.Points)
                            {
                                champions.Insert(i, currentPlayerScore);
                                champions.RemoveAt(champions.Count - 1);
                                break;
                            }
                        }
                    }

                    champions.Sort(
                        (Score firstPlayerName, Score secondPlayerName) =>
                                secondPlayerName.Name.CompareTo(firstPlayerName.Name));
                    champions.Sort(
                        (Score firstPlayerScore, Score secondPlayerScore) =>
                                secondPlayerScore.Points.CompareTo(firstPlayerScore.Points));
                    ShowScoreboard(champions);

                    gameField = CreateGameField();
                    bombsField = SetupBombsField();
                    pointCounter = 0;
                    isDead = false;
                    isNewGame = true;
                }

                if (hasWon)
                {
                    Console.WriteLine("BRAVOOOS! You have opened all cells without dying.");
                    DrawGameField(bombsField);

                    Console.WriteLine("Enter your name: ");
                    var nickname = Console.ReadLine();

                    var playerScore = new Score(nickname, pointCounter);
                    champions.Add(playerScore);
                    ShowScoreboard(champions);
                    gameField = CreateGameField();
                    bombsField = SetupBombsField();
                    pointCounter = 0;
                    isDead = false;
                    hasWon = true;
                }
            }
            while (gameCommand != "exit");
                     
            Console.Read();
        }

        private static void ShowScoreboard(List<Score> points)
        {
            var leaderboard = new StringBuilder();
          
            leaderboard.AppendLine("Leaderboard:");
            if (points.Count > 0)
            {
                for (var i = 0; i < points.Count; i++)
                {                   
                    leaderboard.AppendLine($"{i + 1}. {points[i].Name} --> {points[i].Points} cells");
                }                
            }
            else
            {
                leaderboard.AppendLine("No scores yet");
            }
        }

        private static void MakeMove(char[,] gameField, char[,] bombsField, int row, int column)
        {
            var bombsCount = GetBombsCount(bombsField, row, column);
            bombsField[row, column] = bombsCount;
            gameField[row, column] = bombsCount;
        }

        private static void DrawGameField(char[,] gameField)
        {
            var board = new StringBuilder();
            var rows = gameField.GetLength(0);
            var columns = gameField.GetLength(1);
    
            board.AppendLine("0 1 2 3 4 5 6 7 8 9");
            board.AppendLine("---------------------");
            for (var i = 0; i < rows; i++)
            {                
                board.Append($"{i} | ");
                for (var j = 0; j < columns; j++)
                {                 
                    board.Append($"{gameField[i, j]}");
                }

                board.Append("|").AppendLine();                           
            }

            board.AppendLine("---------------------");           
        }

        private static char[,] CreateGameField()
        {
            int boardRows = 5;
            int boardColumns = 10;
            char[,] board = new char[boardRows, boardColumns];
            for (var i = 0; i < boardRows; i++)
            {
                for (var j = 0; j < boardColumns; j++)
                {
                    board[i, j] = '?';
                }
            }

            return board;
        }

        private static char[,] SetupBombsField()
        {
            int rows = 5;
            int columns = 10;
            char[,] gameField = new char[rows, columns];

            for (var i = 0; i < rows; i++)
            {
                for (var j = 0; j < columns; j++)
                {
                    gameField[i, j] = '-';
                }
            }

            var minesList = new List<int>();
            while (minesList.Count < 15)
            {
                var rng = new Random();
                var randomNumber = rng.Next(50);
                if (!minesList.Contains(randomNumber))
                {
                    minesList.Add(randomNumber);
                }
            }

            foreach (var randomNum in minesList)
            {
                var column = randomNum / columns;
                var row = randomNum % columns;
                if (row == 0 && randomNum != 0)
                {
                    column--;
                    row = columns;
                }
                else
                {
                    row++;
                }

                gameField[column, row - 1] = '*';
            }

            return gameField;
        }

        private static void ScoreSetup(char[,] gameField)
        {
            var rows = gameField.GetLength(0);
            var columns = gameField.GetLength(1);

            for (var row = 0; row < rows; row++)
            {
                for (var column = 0; column < columns; column++)
                {
                    if (gameField[row, column] != '*')
                    {                      
                        gameField[row, column] = GetBombsCount(gameField, row, column);
                    }
                }
            }
        }

        private static char GetBombsCount(char[,] gameField, int rows, int columns)
        {
            var brojkata = 0;
            var fieldRows = gameField.GetLength(0);
            var fieldColumns = gameField.GetLength(1);

            if (rows - 1 >= 0)
            {
                if (gameField[rows - 1, columns] == '*')
                {
                    brojkata++;
                }
            }

            if (rows + 1 < fieldRows)
            {
                if (gameField[rows + 1, columns] == '*')
                {
                    brojkata++;
                }
            }

            if (columns - 1 >= 0)
            {
                if (gameField[rows, columns - 1] == '*')
                {
                    brojkata++;
                }
            }

            if (columns + 1 < fieldColumns)
            {
                if (gameField[rows, columns + 1] == '*')
                {
                    brojkata++;
                }
            }

            if ((rows - 1 >= 0) && (columns - 1 >= 0))
            {
                if (gameField[rows - 1, columns - 1] == '*')
                {
                    brojkata++;
                }
            }

            if ((rows - 1 >= 0) && (columns + 1 < fieldColumns))
            {
                if (gameField[rows - 1, columns + 1] == '*')
                {
                    brojkata++;
                }
            }

            if ((rows + 1 < fieldRows) && (columns - 1 >= 0))
            {
                if (gameField[rows + 1, columns - 1] == '*')
                {
                    brojkata++;
                }
            }

            if ((rows + 1 < fieldRows) && (columns + 1 < fieldColumns))
            {
                if (gameField[rows + 1, columns + 1] == '*')
                {
                    brojkata++;
                }
            }

            return char.Parse(brojkata.ToString());
        }

        public class Score
        {
            public Score()
            {
            }

            public Score(string name, int points)
            {
                this.Name = name;
                this.Points = points;
            }

            public string Name { get; set; }

            public int Points { get; set; }
        }
    }
}
