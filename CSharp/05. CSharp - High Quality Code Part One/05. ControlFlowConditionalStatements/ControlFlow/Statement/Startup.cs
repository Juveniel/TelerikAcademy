namespace Statement
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            // First fragment refactored
            var potato = new Potato();

            if (potato.IsPeeled && !potato.IsRotten)
            {
                Cook(potato);
            }

            // Second Fragment refactored
            var x = 0;
            var y = 0;
            var minX = 0;
            var maxX = 0;
            var minY = 0;
            var maxY = 0;
            var shouldVisitCell = true;

            bool isInRangeX = x >= minX && x <= maxX;
            bool isInRangeY = minY >= y && maxY <= y;

            if (isInRangeX && isInRangeY && shouldVisitCell)
            {
                VisitCell();
            }
        }

        private static void Cook(Potato potato)
        {
            throw new NotImplementedException();
        }

        private static void VisitCell()
        {
            throw new NotImplementedException();
        }
    }
}
