using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Xml;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ProcessingJSON.Models;

namespace ProcessingJSON
{
    internal class Startup
    {
        private static void Main()
        {
            const string FeedUrl = "https://www.youtube.com/feeds/videos.xml?channel_id=UCLC-vbm7OWvpbqzXaoAMGGw";
            const string FileSavePath = "../../youtube.xml";

            // 1. Download the content of the feed programatically
            DownloadRssFeed(FeedUrl, FileSavePath);

            // 2. Parse xml feed to json
            var jsonData = ParseXmlFeedToJson(FileSavePath);

            // 3. Get titles from json
            PrintFeedTitles(jsonData);

            // 4. Parse json to poco
            var videos = ConvertJsonToPocos(jsonData);

            // 5. Create Html from poco
            CreateFeedHtml(videos);
        }

        private static void DownloadRssFeed(string url, string pathToSave)
        {  
            var client = new WebClient();

            client.DownloadFile(url, pathToSave);
        }

        private static string ParseXmlFeedToJson(string xmlPath)
        {      
            var document = new XmlDocument();
            document.Load(xmlPath);

            var root = document.DocumentElement;
            var jsonFromXml = JsonConvert.SerializeXmlNode(root, Newtonsoft.Json.Formatting.Indented);       
           
            return jsonFromXml;
        }

        private static void PrintFeedTitles(string jsonData)
        {
            var jObject = JObject.Parse(jsonData);
            var videoTitles = jObject["feed"]["entry"].Select(e => e["title"]);

            Console.WriteLine("Feed titles: ");
            foreach (var title in videoTitles)
            {
                Console.WriteLine(title);
            }
        }

        private static IEnumerable<YouTubeVideo> ConvertJsonToPocos(string jsonData)
        {
            var jObject = JObject.Parse(jsonData);
            var videosList = jObject["feed"]["entry"];

            return videosList.Select(video => JsonConvert.DeserializeObject<YouTubeVideo>(video.ToString())).ToList();
        }

        private static void CreateFeedHtml(IEnumerable<YouTubeVideo> videos)
        {
            var html = new StringBuilder();

            html.AppendLine("<!DOCTYPE html>");
            html.AppendLine("<html>");
            html.AppendLine("<title>Telerik Academy Videos</title>");
            html.AppendLine("<body>"); 

            foreach (var video in videos)
            {
                html.AppendLine("<div>");
                html.AppendLine($"<div><a href=\"{video.Link.Url}\">{video.Title}</a></div>");     
                html.AppendLine("</div>");
            }

            html.AppendLine("</body>");
            html.AppendLine("</html>");

            File.WriteAllText("../../youTubeVideos.html", html.ToString(), Encoding.UTF8);
        }
    }
}
