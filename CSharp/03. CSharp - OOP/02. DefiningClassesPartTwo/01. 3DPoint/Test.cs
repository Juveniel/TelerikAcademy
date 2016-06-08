namespace _01._3DPoint
{
    using System;

    public class Test
    {
        public static void Main()
        {        
            /* Create some points */
            Point3D firstPoint = new Point3D(1, 1, 1);
            Point3D secondPoint = new Point3D(2, 2, 2);
            Point3D thirPoint = new Point3D(5, 5, 5);

            Console.WriteLine("First point: {0}", firstPoint.ToString());
            Console.WriteLine("Second point: {0}", secondPoint.ToString());
            Console.WriteLine("Third point: {0} \r\n", thirPoint.ToString());

            /* Cal distance for first and third point */
            Console.WriteLine("Distance between first and second point: {0:F2} \r\n", Distance3D.CalculateDistance(firstPoint, thirPoint));

            /* Add new path */
            Path firstPath = new Path();
            firstPath.AddPoint(firstPoint);
            firstPath.AddPoint(secondPoint);
            firstPath.AddPoint(secondPoint);
            firstPath.AddPoint(thirPoint);

            /* Display created path points */
            Console.WriteLine("Current path: \r\n{0}", firstPath.ToString());           

            /* Save newly created path */
            PathStorage.SavePath(firstPath);

            /* Load path and print it */
            var finalPath = PathStorage.LoadPath();

            Console.WriteLine("Loaded path: \r\n{0}", finalPath.ToString());                                        
        }
    }
}
