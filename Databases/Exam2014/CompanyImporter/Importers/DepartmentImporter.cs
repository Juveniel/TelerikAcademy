using System;
using System.IO;
using Company.Data;
using Company.Importer.Importers.Contracts;

namespace Company.Importer.Importers
{
    public class DepartmentImporter : IImporter
    {
        private const int NumberOfDepartments = 50;

        public string Message
        {
            get { return "Importing departments"; }
        }

        public int Order
        {
            get { return 1; }
        }

        public Action<CompanyEntities, TextWriter> Import
        {
            get
            {
                return (db, tr) =>
                {
                    for (var i = 0; i < NumberOfDepartments; i++)
                    {
                        db.Departments.Add(new Department()
                        {
                            Name = $"Department {i}"
                        });

                        if (i % 10 == 0)
                        {
                            tr.Write(".");
                        }

                        if (i % 100 == 0)
                        {
                            db.SaveChanges();
                            db = new CompanyEntities();
                        }
                    }

                    db.SaveChanges();
                };
            }
        }
    }
}
