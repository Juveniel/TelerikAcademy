namespace School.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Models;
    using System;
    using System.Linq;

    [TestClass]
    public class CourseTest
    {
        private School testSchool;
        private Student testStudent;
        private Course testCourse;

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void NullNameInConstructor()
        {
            testCourse = new Course(null);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void EmptyNameInConstructor()
        {
            testCourse = new Course(string.Empty);
        }

        [TestMethod]
        public void ShouldReturnCorrectName()
        {
            testCourse = new Course("C# Fundamentals");

            Assert.AreEqual<string>("C# Fundamentals", testCourse.Name);
        }

        [TestMethod]
        public void AddStudent_ShouldAddStudentCorrectly()
        {
            testCourse = new Course("C# Advanced");
            testStudent = new Student("Gosho0", 12312);

            testCourse.AddStudent(testStudent);

            Assert.AreSame(testStudent, testCourse.Students.First());
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void AddStudent_ShouldThrowExceptionWhenNull()
        {
            testCourse = new Course("C# Advanced");
            testCourse.AddStudent(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AddStudent_ShouldThrowExceptionIfCourseCapacityIsReached()
        {
            testCourse = new Course("C# OOP");

            for (var i = 0; i < 35; i++)
            {
                testCourse.AddStudent(new Student(i.ToString(), 12311 + i));
            }
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void AddStudent_ShouldThrowExceptionIfStudentExisting()
        {
            testCourse = new Course("C# Advanced");
            testStudent = new Student("Gosho", 12312);

            testCourse.AddStudent(testStudent);
            testCourse.AddStudent(testStudent);
        }

        [TestMethod]
        public void RemoveStudent_ShouldRemoveStudentCorrectly()
        {
            testCourse = new Course("C# Advanced2");
            testStudent = new Student("Gosho12", 12333);

            testCourse.AddStudent(testStudent);
            testCourse.RemoveStudent(testStudent);

            Assert.IsTrue(!testCourse.Students.Any());
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void RemoveStudent_ShouldThrowExceptionIfNull()
        {
            testCourse = new Course("C# Advanced2");
            testCourse.RemoveStudent(null);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void RemoveStudent_ShouldThrowExceptionIfStudentDoesntExist()
        {
            testCourse = new Course("C# Advanced23");
            testStudent = new Student("Ivan", 12323);

            testCourse.RemoveStudent(testStudent);
        }
    }
}
