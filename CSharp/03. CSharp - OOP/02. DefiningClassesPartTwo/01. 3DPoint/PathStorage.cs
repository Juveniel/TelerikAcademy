namespace _01._3DPoint
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public static class PathStorage
    {
        public static void SavePath(Path path)
        {            
            using (StreamWriter writer = new StreamWriter(@"../../Paths.txt"))
            {
                try
                {
                    foreach (var point in path.PointPathList)
                    {
                        writer.WriteLine(point);
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

        public static List<Path> LoadPath(Path path)
        {
            List<Path> pathsLoaded = new List<Path>();

            try
            { 
                using (StreamReader reader = new StreamReader("TestFile.txt"))
                {
                    string line = reader.ReadLine();

                    while (!string.IsNullOrEmpty(line))
                    {

                    }
                    Console.WriteLine(line);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

            return pathsLoaded;
        }
    }    
}
