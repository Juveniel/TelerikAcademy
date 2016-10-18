using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Xsl;

namespace XmlProcessing
{
    internal class Startup
    {
        private static void Main()
        {
            // 2. Extracts all artists from catalogue
            GetAllArtists();

            // 3. Extract all artists from catalogue(with Xpath
            GetAllArtistWithXPath();

            // 4. Delete all albums with cost > 20
           // DeleteAlbumsWithCostAbove(20);

            // 5. Extract all song titles with XML reader
            ExtractAllSongTitlesWithReader();

            // 6. Extract all song titles with LINQ
            ExtractAllSongTitleWithLinq();

            // 7. Create XML file from text file
            TextFileToXml();

            // 8. Create XML file for albums
            ExtractAlbumsFromCatalogue();

            // 9. DirectoryStructureToXml
            TraverseDirectory();

            // 11. Extract album prices 5 years ago
            ExtractAlbumPrices();

            // 12. Extract album prices 5 years ago with LINQ
            ExtractAlbumPricesLinq();

            // 14. Generate Html from the XML catalogue
            GenerateHtmlFromXml();
        }

        private static void GetAllArtists()
        {
            const string url = "../../XML/catalogue.xml"; 
            var artistAlbums = new Dictionary<string, int>();
          
            var catalogue = new XmlDocument();
            catalogue.Load(url);

            var rootNode = catalogue.DocumentElement;
            if (rootNode != null)
            {
                foreach (XmlNode node in rootNode.ChildNodes)
                {
                    var xmlElement = node["artist"];          

                    if (xmlElement == null)
                    {
                        continue;
                    }

                    var currentArtist = xmlElement.InnerText;
                    if (!artistAlbums.ContainsKey(currentArtist))
                    {
                        artistAlbums.Add(currentArtist, 0);
                    }

                    artistAlbums[currentArtist]++;
                }
            }              

            foreach (var artist in artistAlbums)
            {
                Console.WriteLine($"Artist: {artist.Key}, Number of albums: {artist.Value}");
            }
        }

        private static void GetAllArtistWithXPath()
        {
            const string url = "../../XML/catalogue.xml";
            const string xPathUrl = "/catalogue/album";

            var artistAlbums = new Dictionary<string, int>();

            var catalogue = new XmlDocument();
            catalogue.Load(url);

            var artistsList = catalogue.SelectNodes(xPathUrl);
            
            foreach (XmlNode node in artistsList)
            {
                var xmlElement = node["artist"];

                if (xmlElement == null)
                {
                    continue;
                }

                var currentArtist = xmlElement.InnerText;
                if (!artistAlbums.ContainsKey(currentArtist))
                {
                    artistAlbums.Add(currentArtist, 0);
                }

                artistAlbums[currentArtist]++;
            }
            

            foreach (var artist in artistAlbums)
            {
                Console.WriteLine($"XPATH Artist: {artist.Key}, Number of albums: {artist.Value}");
            }
        }

        private static void DeleteAlbumsWithCostAbove(int cost)
        {
            const string url = "../../XML/catalogue.xml";

            var catalogue = new XmlDocument();
            catalogue.Load(url);

            var rootNode = catalogue.DocumentElement;

            if (rootNode != null)
            {
                foreach (XmlElement element in rootNode.ChildNodes)
                {
                    var xmlElement = element["price"];
                                    
                    if (xmlElement != null && int.Parse(xmlElement.InnerText) > 20)
                    {
                        rootNode.RemoveChild(element);
                    }
                }

                catalogue.Save(url);
            }                           
        }

        private static void ExtractAllSongTitlesWithReader()
        {
            const string url = "../../XML/catalogue.xml";

            using (var reader = XmlReader.Create(url))
            {
                while (reader.Read())
                {
                    if (reader.Name == "title" && reader.NodeType == XmlNodeType.Element)
                    {
                        Console.WriteLine($"Title: {reader.ReadInnerXml()}");
                    }
                }
            }
        }

        private static void ExtractAllSongTitleWithLinq()
        {
            const string url = "../../XML/catalogue.xml";
            var catalogue = XDocument.Load(url);

            var songsList =
                from title in catalogue.Descendants("title")
                select new
                {
                    Title = title.Value
                };

            foreach (var song in songsList)
            {
                Console.WriteLine($"LINQ Song title: {song.Title}");
            }
        }

        private static void TextFileToXml()
        {
            const string personTextFileUrl = "../../XML/person.txt";
            var personData = File.ReadAllLines(personTextFileUrl);
             
            var peopleList = new XElement("people",
                from person in personData
                let fields = person.Split('|')
                select new XElement("person",
                     new XElement("name", fields[0]),
                     new XElement("address", fields[1]),
                     new XElement("telephone", fields[2])
                )
            );

            peopleList.Save("../../XML/people.xml");
        }

        private static void ExtractAlbumsFromCatalogue()
        {
            var writer = new XmlTextWriter("../../XML/album.xml", Encoding.UTF8);
            var name = string.Empty;
            var author = string.Empty;

            using (writer)
            {
                writer.WriteStartDocument();
                writer.Formatting = Formatting.Indented;
                writer.WriteStartElement("albums");

                using (var reader = XmlReader.Create("../../XML/catalogue.xml"))
                {
                    while (reader.Read())
                    {
                        if (reader.Name == "name")
                        {
                            name = reader.ReadInnerXml();
                        }

                        if (reader.Name == "artist")
                        {
                            author = reader.ReadInnerXml();
                            WriteAlbum(writer, name, author);
                        }                      
                    }                    
                }

                writer.WriteEndDocument();
            }             
        }

        private static void WriteAlbum(XmlWriter writer, string name, string artist)
        {
            writer.WriteStartElement("album");
            writer.WriteElementString("name", name);
            writer.WriteElementString("artist", artist);
            writer.WriteEndElement();
        }

        private static void TraverseDirectory()
        {
            var writer = new XmlTextWriter("../../XML/directory.xml", Encoding.UTF8);
            var sourceDir = new DirectoryInfo("../../");

            using (writer)
            {
                writer.WriteStartDocument();
                writer.Formatting = Formatting.Indented;           
                writer.WriteStartElement("directories");

                BuildXml(writer, sourceDir);

                writer.WriteEndDocument();
            }
        }

        private static void BuildXml(XmlWriter writer, DirectoryInfo dirInfo)
        {
            var files = dirInfo.GetFiles();
            var dirs = dirInfo.GetDirectories();

            if (files.Length == 0 && dirs.Length == 0)
            {
                return;
            }
              
            writer.WriteStartElement("dir");
            writer.WriteAttributeString("name", dirInfo.Name);

            foreach (var file in files)
            {
                writer.WriteElementString("file", file.Name);
            }
            foreach (var subDir in dirs)
            {
                BuildXml(writer, subDir);
            }

            writer.WriteEndElement();
        }

        private static void ExtractAlbumPrices()
        {
            const int YearsAgo = 5;
            const string xPathQuery = "catalogue/album";
                   
            var catalogue = new XmlDocument();
            catalogue.Load("../../XML/catalogue.xml");                   

            var albumsList = catalogue.SelectNodes(xPathQuery);

            Console.WriteLine($"Albums published more than {YearsAgo} years ago:");
            foreach (XmlNode album in albumsList)
            {
                var publishYear = album.SelectSingleNode("year").InnerText;

                if (int.Parse(publishYear) > (DateTime.Now.Year - YearsAgo))
                {
                    continue;
                }

                var name = album.SelectSingleNode("name").InnerText;
                var price = album.SelectSingleNode("price").InnerText;

                Console.WriteLine($"{name}: price {price}");
            }
        }

        private static void ExtractAlbumPricesLinq()
        {
            const int YearsAgo = 5;

            var catalogue = XDocument.Load("../../XML/catalogue.xml");           

            var albums =
                from album in catalogue.Descendants("album")
                where int.Parse(album.Element("year").Value) + YearsAgo < DateTime.Now.Year
                select new
                {
                    Name = album.Element("name").Value,
                    Price = album.Element("price").Value
                };

            Console.WriteLine($"Albums published {YearsAgo} years ago:");
            foreach (var album in albums)
            {
                Console.WriteLine($"{album.Name}: price - {album.Price}");
            }
        }

        private static void GenerateHtmlFromXml()
        {
            var xslt = new XslCompiledTransform();
            xslt.Load("../../XML/catalogue.xslt");
            xslt.Transform("../../XML/catalogue.xml", "../../XML/catalogue.html");
        }
    }
}
