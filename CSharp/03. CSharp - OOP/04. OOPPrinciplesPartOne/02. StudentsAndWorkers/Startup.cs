namespace StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using Extensions;
    using Models;

    public class Startup
    {
        private static List<Student> students = new List<Student>
        {
            new Student("Ivan", "Petrov", 5),
            new Student("Gosho", "Goshev", 2),
            new Student("Stanka", "Staneva", 2),
            new Student("Martina", "Martinova", 3),
            new Student("Joro", "Iliev", 6),
            new Student("Penka", "Penkova", 4),
            new Student("Djo", "Petrov", 4),
            new Student("Ivanka", "Ivanova", 2),
            new Student("Pesho", "Kartelov", 5),
            new Student("Ivan", "Ivanov", 5),
        };

        private static List<Worker> workers = new List<Worker>
        {
            new Worker("Stoio", "Stoev", 250, 8),
            new Worker("Natali", "Ivanova", 300, 6),
            new Worker("Mincho", "Praznikov", 100, 3),
            new Worker("Genadi", "Genadiev", 1000, 8),
            new Worker("Sonq", "Ilieva", 2500, 6),
            new Worker("Drago", "Dragoev", 30000, 8),
            new Worker("Simo", "Simov", 660, 4),
            new Worker("Kameliq", "Ivanova", 150, 7),
            new Worker("Gencho", "Genchev", 445, 6),
            new Worker("Ivan", "Ivanov", 500, 5),
        };

        public static void Main()
        {
            // 1. Print initial collection of students
            Console.WriteLine("Students collection: ");
            students.PrintCollection<Student>();

            // 2. Sort students by grade asc
            Console.WriteLine("Sorted by grade ascending: ");
            students = students.OrderStudentsByGrade<Student>();
            students.PrintCollection<Student>();
        
            // 3. Print initial collection of Workers
            Console.WriteLine("Workers collection: ");
            workers.PrintCollection<Worker>();

            // 4. Sort workers by money per hour descending
            Console.WriteLine("Sorted by money per hour ascentind");
            workers = workers.OrderWorkersByMoneyPerHour<Worker>();
            workers.PrintCollection<Worker>();

            // 5. Merge collections
            Console.WriteLine("Merged collection of people ordered by name");
            var people = students.ConcatenateCollections<Human>(workers);
            people.PrintCollection<Human>();
        }
    }
}
