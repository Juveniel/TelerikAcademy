using System;
using System.Collections.Generic;
using System.Text;

namespace _12.ParseUrl
{
    /// <summary>
    /// Write a program that parses an URL address given in the format:
    /// [protocol]://[server]/[resource] and extracts from it the [protocol], 
    /// [server] and [resource] elements.
    /// </summary>
    class ParseUrl
    {
        static void Main(string[] args)
        {
            string url = Console.ReadLine();

            PrintUrlData(ExtractDataFromUrl(url));
        }

        private static Dictionary<string, string> ExtractDataFromUrl(string url)
        {
            Dictionary<string, string> urlData = new Dictionary<string, string>();
            StringBuilder sb = new StringBuilder();
            int startIndex = 0;

            //protocol
            for (int i = startIndex; i < url.Length; i++)
            {
                if(url[i] != ':')
                {
                    sb.Append(url[i]);
                }
                else
                {
                    urlData.Add("protocol", sb.ToString());                    
                    startIndex = i;
                    sb.Clear();
                    break;
                }           
            }

            //server
            for(int j = startIndex + 3; j < url.Length; j++)
            {
                if(url[j] != '/')
                {
                    sb.Append(url[j]);
                }
                else
                {
                    urlData.Add("server", sb.ToString());
                    startIndex = j;
                    sb.Clear();
                    break;
                }
            }

            //resource
            urlData.Add("resource", url.Substring(startIndex));

            return urlData;
        }

        private static void PrintUrlData(Dictionary<string, string> data)
        {
            foreach(KeyValuePair<string, string> resource in data)
            {
                Console.WriteLine("[{0}] = {1}", resource.Key, resource.Value);
            }
        }
    }
}
