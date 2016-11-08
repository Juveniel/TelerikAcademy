using System;
using System.IO;
using System.Linq;
using Company.Data;
using Company.Importer.Importers.Contracts;

namespace Company.Importer.Importers
{
    public class ReportImporter : IImporter
    {
        public string Message
        {
            get { return "Importing reports"; }
        }

        public int Order
        {
            get { return 4; }
        }

        public Action<CompanyEntities, TextWriter> Import
        {
            get
            {
                return (db, tr) =>
                {
                    var employeeIds = db.Employees.Select(e => e.Id).ToList();

                    for (var i = 0; i < employeeIds.Count; i++)
                    {
                        var reportsCount = RandomGenerator.RandomNumber(25, 75);

                        for (int j = 0; j < reportsCount; j++)
                        {                           
                            var report = new Report
                            {
                                EmployeeId = employeeIds[i],
                                Time = RandomGenerator.RandomDateTime(before: DateTime.Now)
                            };

                            db.Reports.Add(report);
                        }

                        tr.Write(".");

                        db.SaveChanges();
                        db.Dispose();
                        db = new CompanyEntities();
                    }                    
                };
            }
        }
    }
}
