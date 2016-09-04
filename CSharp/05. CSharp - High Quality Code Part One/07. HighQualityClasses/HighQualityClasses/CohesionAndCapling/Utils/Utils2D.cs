﻿namespace CohesionAndCapling.Utils
{
    using System;

    public static class Utils2D
    {
        public static double CalcDistance2D(double x1, double y1, double x2, double y2)
        {
            var distance = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));

            return distance;
        }

        public static double CalcDiagonal2D(double width, double height)
        {
            var distance = CalcDistance2D(0, 0, width, height);

            return distance;
        }       
    }
}
