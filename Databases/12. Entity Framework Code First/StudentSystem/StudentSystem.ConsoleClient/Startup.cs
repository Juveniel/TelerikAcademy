using System;
using System.Linq;
using StudentSystem.Data;
using StudentSystem.Models;

namespace StudentSystem.ConsoleClient
{
    public class Startup
    {
        private static Random rnd = new Random();

        public static void Main()
        {            
            using (var context = new StudentSystemDbContext())
            {
                /* Create db if not existing */
                context.Database.CreateIfNotExists();
                
                /* Seed Data */
                SeedData(context);

                /* Show Courses */
                Console.WriteLine("Courses:");
                foreach (var course in context.Courses)
                {
                    Console.WriteLine($"Course: {course.Name}");
                }
            }
        }

        
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[rnd.Next(s.Length)]).ToArray());
        }

        private static void SeedData(StudentSystemDbContext dbContext)
        {
            for (int i = 0; i < 20; i++)
            {
                var student = new Student()
                {
                    Name = RandomString(6),
                    Number = i
                };

                var course = new Course()
                {
                    Name = "Course" + RandomString(4),
                    Description =  RandomString(30)
                };

                
                course.Students.Add(student);
                student.Courses.Add(course);

                var homework = new Homework()
                {
                    CourseId = course.Id,
                    Course = course,
                    StudentId = student.Id,
                    Student = student,
                    TimeSent = DateTime.Now,
                    Content = RandomString(50),
                };          

                student.Homeworks.Add(homework);
                course.Homeworks.Add(homework);

                dbContext.Courses.Add(course);
                dbContext.Students.Add(student);                
                dbContext.Homeworks.Add(homework);
                dbContext.SaveChanges();
            }
        }
    }
}
