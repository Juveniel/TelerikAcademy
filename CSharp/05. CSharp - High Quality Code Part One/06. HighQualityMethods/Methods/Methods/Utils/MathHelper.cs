namespace Methods.Utils
{
    using System;
    using System.Collections.Generic;

    internal static class MathHelper
    {
        internal static double CalculateTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Sides should ne positeve!");
            }

            var semiPerimeter = (a + b + c) / 2;
            var area = Math.Sqrt(semiPerimeter * (semiPerimeter - a) * (semiPerimeter - b) * (semiPerimeter - c));

            return area;
        }

        internal static string NumberToWord(int number)
        {
            var digitPairs = new Dictionary<int, string>()
            {
                { 0, "zero" },
                { 1, "one" },
                { 2, "two" },
                { 3, "three" },
                { 4, "four" },
                { 5, "five" },
                { 6, "six" },
                { 7, "sevem" },
                { 8, "eight" },
                { 9, "nine" }
            };

            var result = string.Empty;
            if (digitPairs.ContainsKey(number))
            {
                result = digitPairs[number];
            }
            else
            {
                throw new ArgumentException("Number is not a digit.");
            }

            return result;
        }
        
        internal static int FindMaxValue(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new ArgumentException("There are no input argumnets!");
            }

            var maxValue = int.MinValue;
            for (var i = 1; i < elements.Length; i++)
            {
                if (elements[i] > maxValue)
                {
                    maxValue = elements[i];
                }
            }

            return maxValue;
        }
        
        internal static double CalculateDistance(
            double x1, 
            double y1, 
            double x2, 
            double y2,
            out bool isHorizontal,
            out bool isVertical)
        {
            isHorizontal = y1 == y2;
            isVertical = x1 == x2;

            var distance = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));

            return distance;
        }
    }
}
