namespace Student
{
    using System;
    using Enumarations;
    using Models;

    public class Startup
    {
        internal static void Main()
        {
            var firstStudent = new Student(
                "Ivan",
                "Ivanov",
                "Petrov",
                "123231AB32234",
                "1314 Alpha St.",
                "+1235453445",
                "ivancho@asd.po",
                "Second",
                Specialties.Economy,
                Faculties.Mathematics,
                Universities.Cornell);

            var firstStudentClone = (Student)firstStudent.Clone();

            Console.WriteLine(firstStudent.ToString());
            Console.WriteLine(new string('=', 40));
            Console.WriteLine(firstStudentClone.ToString());
            Console.WriteLine(new string('=', 40));

            Console.WriteLine($"Get hash code: {firstStudent.GetHashCode() == firstStudentClone.GetHashCode()}");
            Console.WriteLine($"Equals: {firstStudent.Equals(firstStudentClone)}");
            Console.WriteLine($"CompateTo: {firstStudent.CompareTo(firstStudentClone)}");
        }
    }
}
