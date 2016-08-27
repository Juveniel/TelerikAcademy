namespace Bunnies
{
    using System.Collections.Generic;
    using System.IO;
    using Bunnies.Contracts;
    using Bunnies.Enumerations;
    using Bunnies.Models;
    using Bunnies.Utils;

    internal class Startup
    {
        public static void Main()
        {
            var bunnies = CreateBunniesList();

            var consoleWriter =  new ConsoleWriter();
            foreach (var bunny in bunnies)
            {
                bunny.Introduce(consoleWriter);                 
            }

            const string bunniesFilePath = @"..\..\bunnies.txt";                     
            using (var streamWriter = new StreamWriter(bunniesFilePath))
            {
                foreach (var bunny in bunnies)
                {
                    streamWriter.WriteLine(bunny.ToString());
                }
            }
        }

        private static IEnumerable<IBunny> CreateBunniesList()
        {
            var bunnies = new List<IBunny>
            {
                new Bunny
                {
                    Name = "Leonid",
                    Age = 1,
                    FurType = FurType.NotFluffy
                },
                new Bunny
                {
                    Name = "Rasputin",
                    Age = 2,
                    FurType = FurType.ALittleFluffy
                },
                new Bunny
                {
                    Name = "Tiberii",
                    Age = 3,
                    FurType = FurType.ALittleFluffy
                },
                new Bunny
                {
                    Name = "Neron",
                    Age = 1,
                    FurType = FurType.ALittleFluffy
                },
                new Bunny
                {
                    Name = "Klavdii",
                    Age = 3,
                    FurType = FurType.Fluffy
                },
                new Bunny
                {
                    Name = "Vespasian",
                    Age = 3,
                    FurType = FurType.Fluffy
                },
                new Bunny
                {
                    Name = "Domician",
                    Age = 4,
                    FurType = FurType.FluffyToTheLimit
                },
                new Bunny
                {
                    Name = "Tit",
                    Age = 2,
                    FurType = FurType.FluffyToTheLimit
                }
            };

            return bunnies;
        }
    }
}
