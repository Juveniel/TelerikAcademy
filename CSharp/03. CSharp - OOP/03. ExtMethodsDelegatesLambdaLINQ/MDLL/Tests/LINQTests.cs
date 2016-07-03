namespace MDLL.Tests
{
    using System;
    using System.Collections.Generic;
    using MDLL.Extensions;
    using MDLL.LINQ;

    public class LINQTests
    {
        public static void Test()
        {
            // Initialize test data
            List<Student> arrayOfStudents = new List<Student>
            {
                new Student("Ivan", "Ivanov", "+359 (02) 885 15 15 15", "ivancho@abv.bg", 12351412, 1, 23, new List<double> { 2.50, 2.5, 3.5, 4.5, 5.5, 6.5 }),
                new Student("Ivo", "Andonov", "+359 885 25 25 25", "andonov@abv.bg", 2342064, 2, 19, new List<double> { 4, 4, 3, 4, 5, 6 }),
                new Student("Spas", "Milkov", "+359 885 35 35 35", "spas@gmail.com,", 1656685424, 2, 15, new List<double> { 5, 5, 3, 4, 5, 6 }),
                new Student("Sonq", "Stoilova", "+359 885 45 45 45", "sonq@abv.bg", 9878675, 2, 27, new List<double> { 2, 6, 3, 6, 5, 6 }), 
                new Student("Mincho", "Praznikov", "+359 (02) 885 55 55 55", "mincho@gmail.com", 7567567, 4, 30, new List<double> { 2, 2, 3, 4, 5, 6 }),
                new Student("Nadq", "Ivanova", "+359 885 65 65 65", "nadq@abv.bg", 32542862, 4, 40, new List<double> { 6, 6, 3, 6, 5, 6 }),
                new Student("Pesho", "Georgiev", "+359 885 75 75 75", "pesho@gmail.com", 135406684, 3, 50, new List<double> { 2, 2, 3, 3, 2, 3 }),
                new Student("Ikarus", "Pavlov", "+359 885 85 85 85", "ikarus@abv.bg", 1346541412, 1, 13, new List<double> { 2, 2, 3, 4, 5, 6 })
            };

            Group[] arrayOfGroups =
            {
                new Group(1, "Mathematics"),
                new Group(2, "Literature"),
                new Group(3, "Biology"),
                new Group(4, "Physics"),
                new Group(5, "Economy")
            };

            // Task 9. select students from group 2 and sort by first name asc (with linq)
            var filteredByGroup = DataQueries.FilterStudentsByGroup<Student>(arrayOfStudents, 2);

            Console.WriteLine("Filtered with LINQ");
            filteredByGroup.PrintCollection<Student>();

            // Task 10. -> same as task 9 but wit hext method
            Console.WriteLine("Filtered with ext method");
            var filteredByGroup2 = arrayOfStudents.FilterStudentByGroup<Student>(2);
            filteredByGroup2.PrintCollection<Student>();

            // Taks 11.-> filter by email domain
            Console.WriteLine("Filtered by email domain: ");
            var filteredByEmail = DataQueries.FilterStudentsByEmail<Student>(arrayOfStudents, "abv.bg");
            filteredByEmail.PrintCollection<Student>();

            // Task 12.-> filter by area code
            Console.WriteLine("Filtered by area code");
            var filteredByAreaCode = DataQueries.FilterStudentsByAreaCode<Student>(arrayOfStudents, "02");
            filteredByAreaCode.PrintCollection<Student>();  

            // Task13. -> extract students by mark
            Console.WriteLine("Filtered by mark (LINQ):");
            var filterByMark = DataQueries.FilterStudentsByMark<Student>(arrayOfStudents, 6);
            foreach (var student in filterByMark)
            {
                Console.WriteLine($"First name: {student.FirstName} Marks: { string.Join(",", student.Marks) }");
            }

            Console.WriteLine();

            // Task 14. -> extract students that have 2 2
            Console.WriteLine("Filter by 2 marks:");
            var filterByTwoMarks = arrayOfStudents.FilterStudentsByTwoMarks<Student>(2, 2);
            filterByTwoMarks.PrintCollection<Student>();
            Console.WriteLine();

            // Task 15. -> extract marks by year
            Console.WriteLine("Extract marks by year:");
            var marksByYear = arrayOfStudents.ExtractStudentMarksByyear<Student>("06");

            foreach (var marksList in marksByYear)
            {
                Console.WriteLine($"{string.Join(",", marksList)}");
            }

            Console.WriteLine();

            // Task 16. -> Extract all student from mathematics department
            Console.WriteLine("Extract students from mathematics dep:");
            var studentsInMathDep = arrayOfStudents.FilterStudentsByDepartment<Student>(arrayOfGroups, "Mathematics");
            studentsInMathDep.PrintCollection<Student>();

            // Task 17. -> Find longest word in arr of strings
            string[] strArrTest = new string[] { "asd", "asdasddas", "1213sadasd", "asdas", "asdasdsdasdaasddas" };
            var longestWord = DataQueries.FindLongestString(strArrTest);
            Console.WriteLine($"String arr => {string.Join(",", strArrTest)}");
            Console.WriteLine($"Longerst word in the array: {longestWord}");
            Console.WriteLine();

            // Task 18. -> Group by group number with linq
            Console.WriteLine("Group b groupNumber with LINQ");
            var groupedStudents = DataQueries.FilterByGroupNumber<Student>(arrayOfStudents);
            foreach (var group in groupedStudents)
            {
                var groupKey = group.Key;
                foreach (var student in group)
                {
                    Console.WriteLine($"Group: {groupKey}  {student.FirstName}");
                }
            }

            Console.WriteLine();

            // Task 19. -> Group by group name (ext method)
            Console.WriteLine("Grouped by groupNumber with ext method: ");
            arrayOfStudents.GroupByGroupNumber<Student>();           
        }   
    }
}
