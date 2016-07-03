namespace School
{
    using System;
    using School.Models;

    public class Startup
    {       
        private const int ClassesCount = 5;
        private const int TeachersCount = 5;

        private static Random rnd = new Random();

        private static string[] arrClasses =
        {
            "FirstA",
            "FirstB",
            "SecondC",
            "SecondD",
            "ThirdE"
        };

        private static string[] teacherNames =
        {
            "Geno",
            "Ivan",
            "Irina",
            "Pecata",
            "Sandokan"
        };

        private static string[] disciplines =
        {
            "Literature",
            "Math",
            "Science",
            "Chemistry",
            "Physics",
            "English",
            "German",
            "French",
            "Sport"
        };

        private static string[] studentNames =
        {
            "Pesho",
            "Kiro",
            "Ivanka",
            "Penka",
            "Mincho",
            "Jana"
        };

        public static void Main()
        {                        
            // 1. Create school
            School firstLanguageSchool = new School("First language school");

            // 2. Add a couple of random classes, students, teachers and siciplines
            for (int i = 0; i < ClassesCount; i++)
            {
                firstLanguageSchool.AddClass(new SchoolClass(arrClasses[i])); 

                for (int j = 0; j < rnd.Next(1, 6); j++)
                {
                    firstLanguageSchool.Classes[i].AddStudent(new Student(j + 1, studentNames[rnd.Next(0, studentNames.Length)]));
                }

                for (int k = 0; k < TeachersCount; k++)
                {
                    firstLanguageSchool.Classes[i].AddTeacher(new Teacher(teacherNames[k]));

                    for (int l = 0; l < rnd.Next(1, 5); l++)
                    {
                        firstLanguageSchool.Classes[i].Teachers[k].AddDiscipline(
                            new Discipline(disciplines[rnd.Next(0, disciplines.Length)], rnd.Next(1, 50), rnd.Next(50, 200)));
                    }
                }
            }

            // 3. Add test comments
            firstLanguageSchool.Classes[0].Comment = "test comment for class FirstA";
            firstLanguageSchool.Classes[0].Teachers[0].Comment = "test comment teacher blabla";
            firstLanguageSchool.Classes[0].Teachers[0].Disciplines[0].Comment = "discipline commnet bla bla";
            firstLanguageSchool.Classes[0].Students[0].Comment = "test comment student";

            // 3.Print school data
            Console.WriteLine(firstLanguageSchool);                   
        }
    }
}
