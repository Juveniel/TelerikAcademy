using System;
using System.Linq;
using System.IO;
using Company.Data;
using Company.Importer.Importers.Contracts;

namespace Company.Importer.Importers
{
    public class ProjectImporter : IImporter
    {
        private const int NumberOfProjects = 1000;

        public string Message
        {
            get { return "Importing projects"; }
        }

        public int Order
        {
            get { return 3; }
        }

        public Action<CompanyEntities, TextWriter> Import
        {
            get
            {
                return (db, tr) =>
                {
                    var allEmployeesIds = db.Employees.Select(e => e.Id).ToList();

                    var currentEmployeeIndex = 0;
                    for (int i = 0; i < NumberOfProjects; i++)
                    {

                        var currentProject = new Project()
                        {
                            Name = RandomGenerator.RandomString(5, 50)
                        };

                        var numberOfEmployeeProjects = RandomGenerator.RandomNumber(2, 8);
                        for (int j = 0; j < numberOfEmployeeProjects; j++)
                        {
                            if (j + currentEmployeeIndex >= allEmployeesIds.Count)
                            {
                                break;
                            }

                            var currentEmployeeId = allEmployeesIds[currentEmployeeIndex];

                            var startDate = RandomGenerator.RandomDateTime(before: DateTime.Now.AddDays(-100));

                            currentProject.EmployeeProjects.Add(new EmployeeProject()
                            {
                                EmployeeId = currentEmployeeId,
                                StartDate = startDate,
                                EndDate = RandomGenerator.RandomDateTime(after: startDate)
                            });

                            currentEmployeeIndex++;
                        }

                        db.Projects.Add(currentProject);

                        if (i % 10 == 0)
                        {
                            tr.Write(".");
                        }

                        if (i % 100 == 0)
                        {
                            db.SaveChanges();
                            db.Dispose();
                            db = new CompanyEntities();
                        }
                    }

                    db.SaveChanges();
                };
            }
        }
    }
}
