namespace CohesionAndCapling
{
    using System;
    using Utils;

    internal class Startup
    {
        internal static void Main()
        {
            Console.WriteLine(FileUtils.GetFileExtension("example"));
            Console.WriteLine(FileUtils.GetFileExtension("example.pdf"));
            Console.WriteLine(FileUtils.GetFileExtension("example.new.pdf"));

            Console.WriteLine(FileUtils.GetFileNameWithoutExtension("example"));
            Console.WriteLine(FileUtils.GetFileNameWithoutExtension("example.pdf"));
            Console.WriteLine(FileUtils.GetFileNameWithoutExtension("example.new.pdf"));

            Console.WriteLine($"Distance in the 2D space = {Utils2D.CalcDistance2D(1, -2, 3, 4):f2}");
            Console.WriteLine($"Distance in the 3D space = {Utils3D.CalcDistance3D(5, 2, -1, 3, -6, 4):f2}");

            Console.WriteLine($"Volume = {Utils3D.CalcVolume(3, 4, 5):f2}");
            Console.WriteLine($"Diagonal XYZ = {Utils3D.CalcDiagonal3D(3, 4, 5):f2}");
            Console.WriteLine($"Diagonal XY = {Utils2D.CalcDiagonal2D(3, 4):f2}");
            Console.WriteLine($"Diagonal XZ = {Utils2D.CalcDiagonal2D(3, 5):f2}");
            Console.WriteLine($"Diagonal YZ = {Utils2D.CalcDiagonal2D(4, 5):f2}");
        }
    }
}
