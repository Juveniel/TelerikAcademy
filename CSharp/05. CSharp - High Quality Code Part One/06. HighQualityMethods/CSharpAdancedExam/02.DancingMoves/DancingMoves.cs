namespace _02.DancingMoves
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class DancingMoves
    {
        private static List<int> floor = new List<int>();
        private static int currentIndex = 0;
        private static int currentResult = 0;

        internal static void Main()
        {
            currentIndex = 0;
            floor = new List<int>();
            currentResult = 0;

            var readLine = Console.ReadLine();
            if (readLine != null)
            {
                floor = readLine.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            }        
                    
            string line = null;

            var resultArr = new List<int>();
            while ((line = Console.ReadLine()) != "stop")
            {
                var arr = line.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

                var times = int.Parse(arr[0]);
                var direction = arr[1];
                var step = int.Parse(arr[2]);

                currentResult = 0;

                Move(times, step, direction);

                resultArr.Add(currentResult);
            }

            Console.WriteLine($"{resultArr.Average(x => x):F1}");
        }

        private static void Move(int times, int step, string direction)
        {
            for (var i = 0; i < times; i++)
            {
                if (direction == "right")
                {
                    currentIndex = (currentIndex + step) % floor.Count;
                }
                else
                {
                    currentIndex = (currentIndex - step) % floor.Count < 0 ? 
                        (floor.Count + (currentIndex - step)) % floor.Count :
                        (currentIndex - step) % floor.Count;
                }

                currentResult += floor[currentIndex];
            }
        }
    }
}
