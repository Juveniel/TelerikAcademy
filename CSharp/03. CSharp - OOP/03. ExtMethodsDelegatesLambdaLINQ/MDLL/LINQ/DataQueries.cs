namespace MDLL.LINQ
{
    using System.Collections.Generic;
    using System.Linq;              

    public static class DataQueries
    {
        public static IEnumerable<Student> FirstBeforeLast(IEnumerable<Student> students)
        {
            var query = from student in students
                        where (student.FirstName.CompareTo(student.LastName) < 0)
                        select student;

            return query.ToArray();
        }

        public static IEnumerable<string> AgeRange<T>(IEnumerable<Student> students, int minAge, int maxAge)
        {
            var query = from student in students
                        where student.Age >= minAge && student.Age <= maxAge
                        select string.Format("{0} {1}", student.FirstName, student.LastName);

            return query;
        }

        public static IEnumerable<Student> OrderStudents<T>(IEnumerable<Student> students)
        {
            var query = from student in students
                        orderby student.FirstName descending, student.LastName descending
                        select student;

            return query.ToArray();
        }

        public static int[] DivibisbleBy7and3(int[] numbers)
        {
            var query = from number in numbers
                        where number % 7 == 0 && number % 3 == 0
                        select number;

            return query.ToArray();
        }

        public static IEnumerable<Student> FilterStudentsByGroup<T>(IEnumerable<Student> students, int group)
        {
            var query = from student in students
                        where student.GroupNumber == @group
                        orderby student.FirstName ascending
                        select student;

            return query.ToArray();
        }

        public static IEnumerable<Student> FilterStudentsByEmail<T>(IEnumerable<Student> students, string domain)
        {
            var query = from student in students
                        where student.Email.Split('@').Last() == domain
                        select student;

            return query.ToArray();
        }

        public static IEnumerable<Student> FilterStudentsByAreaCode<T>(IEnumerable<Student> students, string code)
        {
            var query = from student in students
                        where student.Telephone.Contains($"({code})")
                        select student;

            return query.ToArray();
        }

        public static dynamic FilterStudentsByMark<T>(IEnumerable<Student> students, double mark)
        {
            var query = from student in students
                        where student.Marks.Contains(mark)
                        select new { FirstName = student.FirstName, Marks = student.Marks };

            return query.ToArray();
        }

        public static string FindLongestString(string[] text)
        {
            var query = from c in text
                        orderby c.Length descending
                        select c;
            var longest = query.FirstOrDefault();

            return longest.ToString();
        }

        public static IEnumerable<IGrouping<int, Student>> FilterByGroupNumber<T>(IEnumerable<Student> students)
        {
            var query = from student in students                       
                        group student by student.GroupNumber into newGroup
                        orderby newGroup.Key
                        select newGroup;

            return query.ToArray();                                                                                        
        }      
    }
}
