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
            Point3D thirPoint = new Point3D(3, 3, 3);

            /* Add new path */
            Path firstPath = new Path();
            firstPath.AddPoint(firstPoint);
            firstPath.AddPoint(secondPoint);
            firstPath.AddPoint(secondPoint);
            firstPath.AddPoint(thirPoint);

            /* Display created path points */
            Console.WriteLine(firstPath.ToString());

            /* Save newly created path */
            PathStorage.SavePath(firstPath);

            var finalPath = PathStorage.LoadPath();

            Console.WriteLine(finalPath.ToString());

           // Path loadedPath = PathStorage.LoadPath(firstPath);                                            
        }
    }
}
