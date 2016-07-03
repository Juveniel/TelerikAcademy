namespace MDLL.Extensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class StudentCollectionExtension
    {    
        public static IEnumerable<Student> OrderStudents<T>(this IEnumerable<Student> students)
        {
            var result = students
                .OrderByDescending(x => x.FirstName)
                .ThenByDescending(x => x.LastName);

            return result.ToArray();
        }

        public static IEnumerable<Student> FilterStudentByGroup<T>(this IEnumerable<Student> students, int group)
        {
            var result = students
                .Where(s => s.GroupNumber == group)
                .OrderBy(s => s.FirstName);

            return result.ToArray();
        }

        public static IEnumerable<Student> FilterStudentsByTwoMarks<T>(this IEnumerable<Student> students, double mark, int occurences)
        {       
            var result = students
                .Where(s => s.Marks.Where(x => x == mark)
                .Count() == occurences);

            return result.ToArray();
        }

        public static IEnumerable<List<double>> ExtractStudentMarksByyear<T>(this IEnumerable<Student> students, string year)
        {
            var result = students
                .Where(s => s.FacultyNumber.ToString().Substring(4, 2).Equals(year))
                .Select(s => s.Marks);

            return result.ToArray();
        }

        public static IEnumerable<Student> FilterStudentsByDepartment<T>(
            this IEnumerable<Student> students, IEnumerable<Group> groups, string department)
        {
            var result = students.Join(
                groups.Where(g => g.DepartmentName.Equals(department)),
                student => student.GroupNumber,
                g => g.GroupNumber,
                (student, g) => student);

            return result.ToArray();
        }

        public static void GroupByGroupNumber<T>(this IEnumerable<Student> students)
        {
            var result = students.GroupBy(s => s.GroupNumber, (key, studentsList) => new { key, studentsList });

            foreach (var group in result.OrderBy(x => x.key))
            {
                Console.WriteLine("Group: {0}", group.key);

                foreach (var student in group.studentsList)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName}");
                }
            }
        }

        public static void PrintCollection<T>(this IEnumerable<Student> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();
        }
    }
}
