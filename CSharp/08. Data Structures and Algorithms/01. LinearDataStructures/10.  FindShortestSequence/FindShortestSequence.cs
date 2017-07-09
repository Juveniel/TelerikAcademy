using System;
using System.Collections.Generic;

namespace _10.FindShortestSequence
{
    public class FindShortestSequence
    {
        public static void Main()
        {
            Console.WriteLine("Finding the shortest sequence of operations: ");     

            var startNumber = int.Parse(Console.ReadLine());
            var firstList = new LinkedList<int>();
            firstList.AddLast(startNumber);
            var solutions = new Queue<LinkedList<int>>();
            solutions.Enqueue(firstList);

            Console.Write("Enter end number M: ");
            var endNumber = int.Parse(Console.ReadLine());

            if (startNumber >= endNumber)
            {
                Console.WriteLine("Cannot have start number less than or equal to end number!");
                return;
            }

            var resultList = FindMinOperations(solutions, endNumber);
            Console.Write("Result: ");
            while (resultList.Count > 0)
            {
                Console.Write($"{resultList.First.Value} ");
                resultList.RemoveFirst();
            }

            Console.WriteLine();
        }

        private static LinkedList<int> FindMinOperations(Queue<LinkedList<int>> listsQueue, int endNumber)
        {
            while (true)
            {
                var currentList = listsQueue.Dequeue();
                var currentLastElement = currentList.Last;

                var firstNextValue = currentLastElement.Value + 1;
                var firstNextList = new LinkedList<int>(currentList);
                firstNextList.AddLast(firstNextValue);
                if (firstNextValue < endNumber)
                {
                    listsQueue.Enqueue(firstNextList);
                }
                else if (firstNextValue == endNumber)
                {
                    return firstNextList;
                }

                var secondNextValue = currentLastElement.Value + 2;
                var secondNextList = new LinkedList<int>(currentList);
                secondNextList.AddLast(secondNextValue);
                if (secondNextValue < endNumber)
                {
                    listsQueue.Enqueue(secondNextList);
                }
                else if (secondNextValue == endNumber)
                {
                    return secondNextList;
                }

                var thirdNextValue = currentLastElement.Value * 2;
                var thirdNextList = new LinkedList<int>(currentList);
                thirdNextList.AddLast(thirdNextValue);
                if (thirdNextValue < endNumber)
                {
                    listsQueue.Enqueue(thirdNextList);
                }
                else if (thirdNextValue == endNumber)
                {
                    return thirdNextList;
                }
            }
        }
    }
}
