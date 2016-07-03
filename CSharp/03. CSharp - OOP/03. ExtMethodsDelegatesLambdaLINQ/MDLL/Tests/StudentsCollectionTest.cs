namespace MDLL.Tests
{
    using System;
    using System.Collections.Generic;
    using MDLL.Extensions;
    using MDLL.LINQ;

    public class StudentsCollectionTest
    {
        public static void Test()
        {
            // 1. Init collection
            Student[] arrayOfStudents =
            {
                new Student("Ivan", "Ivanov", "+359 885 15 15 15", "ivancho@abv.bg", 12351412, 1, 23, new List<double>() { 2, 2, 3 }),
                new Student("Ivo", "Andonov", "+359 885 25 25 25", "andonov@abv.bg", 2342424, 2, 19, new List<double>() { 2, 2, 3 }),
                new Student("Spas", "Milkov", "+359 885 35 35 35", "spas@abv.bg", 1656685424, 3, 15, new List<double>() { 2, 2, 3 }),
                new Student("Sonq", "Stoilova", "+359 885 45 45 45", "sonq@abv.bg", 9878675, 3, 27, new List<double>() { 2, 2, 3 }),
                new Student("Mincho", "Praznikov", "+359 885 55 55 55", "mincho@abv.bg", 7567567, 4, 30, new List<double>() { 2, 2, 3 }),
                new Student("Nadq", "Ivanova", "+359 885 65 65 65", "nadq@abv.bg", 32542862, 4, 40, new List<double>() { 2, 2, 3 }),
                new Student("Pesho", "Georgiev", "+359 885 75 75 75", "pesho@abv.bg", 135457684, 3, 50, new List<double>() { 2, 2, 3 }),
                new Student("Ikarus", "Pavlov", "+359 885 85 85 85", "ikarus@abv.bg", 1346541412, 2, 13, new List<double>() { 2, 2, 3 })
            };

            // 2. Print initial state
            foreach (var item in arrayOfStudents)
            {
                Console.WriteLine(item.ToString());
            }

            // Task 3.=======================================
            var sortedStudents = DataQueries.FirstBeforeLast(arrayOfStudents);
            Console.WriteLine("Task3. First before last name: ");
            foreach (var student in sortedStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}");
            }

            // Task 4.=======================================
            Console.WriteLine("\nTask4. Age range");
            var queryAge = DataQueries.AgeRange<Student>(arrayOfStudents, 18, 24);
            foreach (var student in queryAge)
            {
                Console.WriteLine(student);
            }

            // Task 5.=======================================

            // with extension method
            Console.WriteLine("\nTask5. Order students with extension method");
            var ordered = arrayOfStudents.OrderStudents<Student>();
            foreach (var student in ordered)
            {
                Console.WriteLine(student);
            }

            // with linq
            Console.WriteLine("\nTask5. Order students with linq");
            var ordered2 = DataQueries.OrderStudents<Student>(arrayOfStudents);
            foreach (var student in ordered2)
            {
                Console.WriteLine(student);
            }
        }
    }
}
