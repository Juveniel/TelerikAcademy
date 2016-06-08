namespace _01._3DPoint
{
    using System;
    using System.IO;
    using System.Linq;

    public static class PathStorage
    {
        public static void SavePath(Path path)
        {            
            using (StreamWriter writer = new StreamWriter(@"../../PathsSave.txt"))
            {
                try
                {
                    foreach (var point in path.PointPathList)
                    {
                        writer.WriteLine(point.ToString());
                    }
                }
                catch (IOException ex)
                {
                    Console.WriteLine("IO Exception occured: " + ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception occured: " + ex.Message);
                }
            }                       
        }

        public static Path LoadPath()
        {
            Path currentPath = new Path();

            try
            { 
                using (StreamReader reader = new StreamReader(@"../../PathsSave.txt"))
                {
                    while (!reader.EndOfStream)
                    {
                        var coordinates = reader.ReadLine()
                           .Trim()
                           .Split(new[] { '|', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                           .Select(double.Parse)
                           .ToList();

                        var pointToAdd = new Point3D(coordinates[0], coordinates[1], coordinates[2]);

                        currentPath.AddPoint(pointToAdd);
                    }                   
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

            return currentPath;
        }
    }    
}
