using System;
using System.IO;

namespace _03.ReadFileContents
{
    /// <summary>
    /// Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console.
    /// </summary>
    class ReadFileContents
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Enter the files location:");
                string path = Console.ReadLine();
                string textContetn = File.ReadAllText(path);
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("No such dir exists!");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File was not found!");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Null file path!");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Wrong file path");
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("The entered file path is too long - 248 characters are the maximum!");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Unauthorized Access!");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("Invalid file path format!");
            }
            catch (IOException ioEx)
            {
                Console.WriteLine(ioEx.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("{0} - {1}", ex.GetType(), ex.Message);
            }
        }
    }
}
