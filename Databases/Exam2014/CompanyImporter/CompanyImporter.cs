using System;
using System.IO;
using System.Linq;
using System.Reflection;
using Company.Data;
using Company.Importer.Importers.Contracts;

namespace Company.Importer
{
    public class CompanyImporter
    {
        private TextWriter textWriter;

        private CompanyImporter(TextWriter textWriter)
        {
            this.textWriter = textWriter;
        }

        public static CompanyImporter Create(TextWriter textWriter)
        {
            return new CompanyImporter(textWriter);
        }

        public void Import()
        {
            Assembly.GetAssembly(typeof(IImporter))
                .GetTypes()
                .Where(t => typeof(IImporter).IsAssignableFrom(t) && !t.IsAbstract && !t.IsInterface)
                .Select(t => (IImporter)Activator.CreateInstance(t))
                .OrderBy(i => i.Order)
                .ToList()
                .ForEach(i =>
                {
                    this.textWriter.Write(i.Message);
                    i.Import(new CompanyEntities(), this.textWriter);
                    this.textWriter.WriteLine();
                });
        }
    }
}
