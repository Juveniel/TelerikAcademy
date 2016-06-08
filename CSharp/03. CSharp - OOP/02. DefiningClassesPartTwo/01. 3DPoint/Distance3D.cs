namespace _01._3DPoint
{
    using System;

    public static class Distance3D
    {
        public static double CalculateDistance(Point3D pointA, Point3D pointB)
        {
            double deltaX = pointA.PointX - pointB.PointX;
            double deltaY = pointA.PointY - pointB.PointY;
            double deltaZ = pointA.PointZ - pointB.PointZ;

            double distance = Math.Sqrt((deltaX * deltaX) + (deltaY * deltaY) + (deltaZ + deltaZ));

            return distance;
        }
    }
}
