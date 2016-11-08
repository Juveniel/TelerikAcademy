using System;
using System.IO;
using System.Linq;
using Company.Data;
using Company.Importer.Importers.Contracts;

namespace Company.Importer.Importers
{
    public class EmployeeImporter : IImporter
    {
        private const int NumberOfEmployees = 5000;

        public string Message
        {
            get { return "Importing employees"; }
        }

        public int Order
        {
            get { return 2; }
        }

        public Action<CompanyEntities, TextWriter> Import
        {
            get
            {
                return (db, tr) =>
                {
                    var departmentsIds = db.Departments.Select(d => d.Id).ToList();
                    var departmentsCount = departmentsIds.Count();

                    var random = new Random();
                    for (var i = 1; i <= NumberOfEmployees; i++)
                    {
                        var nextDepartmentIndex = random.Next(0, departmentsCount);
                        var nextDepartmentId = departmentsIds[nextDepartmentIndex];

                        var salary = (decimal)random.Next(50000, 200000);

                        var nextSeedEmployee = new Employee()
                        {
                            FirstName = RandomGenerator.RandomString(5, 20),
                            LastName = RandomGenerator.RandomString(5, 20),
                            Salary = salary,
                            DepartmentId = nextDepartmentId
                        };

                        db.Employees.Add(nextSeedEmployee);

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

                    db = new CompanyEntities();
                    var allEmployees = db.Employees.ToList();
                    var employeesCount = allEmployees.Count;
                    var managersCount = (int)Math.Ceiling(employeesCount * 0.05);

                    var employeesPerManager = employeesCount / managersCount;
                    var firstEmployeeIndex = managersCount;

                    for (int manager = 0; manager < managersCount; manager++)
                    {
                        var managerId = allEmployees[manager].Id;

                        for (int employee = firstEmployeeIndex; employee < firstEmployeeIndex + employeesPerManager; employee++)
                        {
                            if (employeesCount <= employee)
                            {
                                break;
                            }

                            allEmployees[employee].ManagerId = managerId;
                        }

                        firstEmployeeIndex += employeesPerManager;
                    }

                    db.SaveChanges();
                };

            }
        }
    }
}
