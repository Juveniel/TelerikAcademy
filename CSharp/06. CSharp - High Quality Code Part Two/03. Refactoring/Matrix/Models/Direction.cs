namespace Matrix.Models
{
    using System;

    public struct Direction
    {
        private int x;
        private int y;

        public Direction(int x, int y) : this()
        {
            this.X = x;
            this.Y = y;
        }

        public int X
        {
            get
            {
                return this.x;
            }

            set
            {
                if (value < -1 || value > 1)
                {
                    throw new ArgumentOutOfRangeException("X cannot be bellow -1 or over 1");
                }

                this.x = value;
            }
        }

        public int Y
        {
            get
            {
                return this.y;
            }

            set
            {
                if (value < -1 || value > 1)
                {
                    throw new ArgumentOutOfRangeException("Y cannot be bellow -1 or over 1");
                }

                this.y = value;
            }
        }
    }
}
