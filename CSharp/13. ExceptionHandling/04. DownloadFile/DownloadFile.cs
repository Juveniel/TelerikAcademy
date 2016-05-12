using System;
using System.Net;

namespace _04.DownloadFile
{
    /// <summary>
    /// Write a program that downloads a file from Internet (e.g. Ninja image) and stores it the current directory.
    /// </summary>
    class DownloadFile
    {
        static void Main(string[] args)
        {
            WebClient client = new WebClient();
            using (client)
            {
                try
                {
                    client.DownloadFile("http://telerikacademy.com/Content/Images/news-img01.png", @"C:\Users\Mitko\Desktop\ninja.png");
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine("{0} - {1}", ae.GetType(), ae.Message);
                }
                catch (WebException webEx)
                {
                    Console.WriteLine("{0} - {1}", webEx.GetType(), webEx.Message);
                    Console.WriteLine("Destination not found!");
                }
                catch (NotSupportedException supportEx)
                {
                    Console.WriteLine("{0} - {1}", supportEx.GetType(), supportEx.Message);
                    Console.WriteLine(supportEx.Message);
                }
                catch (Exception allExp)
                {
                    Console.WriteLine("{0} - {1}", allExp.GetType(), allExp.Message);
                }
            }
        }
    }
}
