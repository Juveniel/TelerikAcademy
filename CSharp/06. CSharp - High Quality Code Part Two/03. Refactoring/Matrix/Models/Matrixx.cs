namespace Matrix.Models
{
    using System;
    using Contracts;

    public class Matrixx
    {
        private const int DirectionsCount = 8;
        private int size;

        public Matrixx(int size)
        {
            this.Row = 0;
            this.Col = 0;
            this.Size = size;
            this.Cells = new int[this.Size, this.Size];
        }

        public int Row { get; set; }

        public int Col { get; set; }

        public int Size
        {
            get
            {
                return this.size;
            }

            set
            {
                if (value <= 0 || value >= 100)
                {
                    throw new ArgumentOutOfRangeException("Matrix size must be between 0 and 100");
                }

                this.size = value;
            }
        }

        public int[,] Cells { get; set; }

        public void Fill(Direction direction, ref int numberCounter)
        {
            while (true)
            {
                this.Cells[this.Row, this.Col] = numberCounter;

                if (!this.CheckForDeadEnd())
                {
                    break;
                }

                while (this.CheckIfShouldChangeDirection(direction))
                {
                    ChangeDirectionToNextPossible(ref direction);
                }

                this.Row += direction.X;
                this.Col += direction.Y;
                numberCounter++;
            }
        }

        public bool FindEmptyCell()
        {
            for (var i = 0; i < this.Size; i++)
            {
                for (var j = 0; j < this.Size; j++)
                {
                    if (this.Cells[i, j] != 0)
                    {
                        continue;
                    }

                    this.Row = i;
                    this.Col = j;
                    return true;
                }
            }

            return false;
        }

        public void Print(IWriter writer)
        {
            for (var row = 0; row < this.Size; row++)
            {
                for (var col = 0; col < this.Size; col++)
                {
                    writer.Write("{0,3}", this.Cells[row, col]);
                }

                writer.WriteLine();
            }
        }

        private static void ChangeDirectionToNextPossible(ref Direction direction)
        {
            var currentDirection = 0;
            int[] dirX = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] dirY = { 1, 0, -1, -1, -1, 0, 1, 1 };

            for (var count = 0; count < DirectionsCount; count++)
            {
                if (dirX[count] != direction.X || dirY[count] != direction.Y)
                {
                    continue;
                }

                currentDirection = count;
                break;
            }

            if (currentDirection == 7)
            {
                direction.X = dirX[0];
                direction.Y = dirY[0];
                return;
            }

            direction.X = dirX[currentDirection + 1];
            direction.Y = dirY[currentDirection + 1];
        }

        private bool CheckForDeadEnd()
        {
            int[] dirX = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] dirY = { 1, 0, -1, -1, -1, 0, 1, 1 };

            for (var i = 0; i < DirectionsCount; i++)
            {
                if (this.Row + dirX[i] >= this.Size || this.Row + dirX[i] < 0)
                {
                    dirX[i] = 0;
                }

                if (this.Col + dirY[i] >= this.Size || this.Col + dirY[i] < 0)
                {
                    dirY[i] = 0;
                }
            }

            for (var i = 0; i < DirectionsCount; i++)
            {
                if (this.Cells[this.Row + dirX[i], this.Col + dirY[i]] == 0)
                {
                    return true;
                }
            }

            return false;
        }

        private bool CheckIfShouldChangeDirection(Direction direction)
        {
            return this.Row + direction.X >= this.Size || this.Row + direction.X < 0 ||
                   this.Col + direction.Y >= this.Size || this.Col + direction.Y < 0 ||
                   this.Cells[this.Row + direction.X, this.Col + direction.Y] != 0;
        }    
    }
}
