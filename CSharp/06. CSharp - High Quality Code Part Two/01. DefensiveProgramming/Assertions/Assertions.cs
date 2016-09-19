namespace Assertions
{
    using System;
    using System.Diagnostics;

    internal class Assertions
    {
        public static void Main()
        {
            var arr = new int[] { 3, -1, 15, 4, 17, 2, 33, 0 };
            Console.WriteLine($"arr = [{string.Join(", ", arr)}]");
            SelectionSort(arr);
            Console.WriteLine($"sorted = [{string.Join(", ", arr)}]");

            SelectionSort(new int[0]);
            SelectionSort(new int[1]);

            Console.WriteLine(BinarySearch(arr, -1000));
            Console.WriteLine(BinarySearch(arr, 0));
            Console.WriteLine(BinarySearch(arr, 17));
            Console.WriteLine(BinarySearch(arr, 10));
            Console.WriteLine(BinarySearch(arr, 1000));
        }

        public static void SelectionSort<T>(T[] arr)
            where T : IComparable<T>
        {
            Debug.Assert(arr != null, "The array is null!");

            for (var index = 0; index < arr.Length - 1; index++)
            {
                var minElementIndex = FindMinElementIndex(arr, index, arr.Length - 1);
                Swap(ref arr[index], ref arr[minElementIndex]);
            }
        }

        public static int BinarySearch<T>(T[] arr, T value) where T : IComparable<T>
        {
            Debug.Assert(arr != null, "Arr ix null.");
            Debug.Assert(value != null, "Value is null.");

            return BinarySearch(arr, value, 0, arr.Length - 1);
        }

        private static int FindMinElementIndex<T>(T[] arr, int startIndex, int endIndex)
            where T : IComparable<T>
        {
            Debug.Assert(arr != null, "The array is null!");
            Debug.Assert(startIndex >= 0, "Start index is negative!");
            Debug.Assert(endIndex >= 0, "End index is negative!");
            Debug.Assert(startIndex <= endIndex, "Starting index is larger than the end index.");

            var minElementIndex = startIndex;
            for (var i = startIndex + 1; i <= endIndex; i++)
            {
                if (arr[i].CompareTo(arr[minElementIndex]) < 0)
                {
                    minElementIndex = i;
                }
            }

            return minElementIndex;
        }

        private static void Swap<T>(ref T x, ref T y)
        {
            Debug.Assert(x != null, "X ix null.");
            Debug.Assert(y != null, "Y is null.");

            var oldX = x;
            x = y;
            y = oldX;
        }
       
        private static int BinarySearch<T>(T[] arr, T value, int startIndex, int endIndex)
            where T : IComparable<T>
        {
            Debug.Assert(arr != null, "The array is null!");
            Debug.Assert(startIndex >= 0, "Start index is negative!");
            Debug.Assert(endIndex >= 0, "End index is negative!");
            Debug.Assert(startIndex <= endIndex, "Starting index is larger than the end index.");

            while (startIndex <= endIndex)
            {
                var midIndex = (startIndex + endIndex) / 2;
                if (arr[midIndex].Equals(value))
                {
                    return midIndex;
                }

                if (arr[midIndex].CompareTo(value) < 0)
                {
                    startIndex = midIndex + 1;
                }
                else
                {
                    endIndex = midIndex - 1;
                }
            }

            return -1;
        }
    }
}
