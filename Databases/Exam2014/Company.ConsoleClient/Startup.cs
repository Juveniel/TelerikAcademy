using System;
using Company.Importer;

namespace Company.ConsoleClient
{
    public class Startup
    {
        public static void Main()
        {
            CompanyImporter.Create(Console.Out).Import();
        }
    }
}
