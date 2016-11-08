using System;
using System.IO;
using Company.Data;

namespace Company.Importer.Importers.Contracts
{
    public interface IImporter
    {
        string Message { get; }

        int Order { get; }

        Action<CompanyEntities, TextWriter> Import { get; }
    }
}