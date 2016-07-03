namespace StudentsAndWorkers.Extensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Models;

    public static class HumanCollectionExtensions
    {
        public static List<Student> OrderStudentsByGrade<Human>(this IEnumerable<Student> students) 
        {
            return students.OrderBy(s => s.Grade).ToList();
        }

        public static List<Worker> OrderWorkersByMoneyPerHour<Human>(this IEnumerable<Worker> workers)
        {
            return workers.OrderByDescending(w => w.MoneyPerHour()).ToList();
        }

        public static List<Human> ConcatenateCollections<T>(this List<Student> students, List<Worker> workers)
        {
            return new List<Human>(students).Concat(workers).OrderBy(p => p.FirstName).ThenBy(p => p.LastName).ToList();
        }

        public static void PrintCollection<Human>(this IEnumerable<Human> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();
        }
    }
}
