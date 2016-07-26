using System.Linq;

namespace School.Tests
{
    using Contracts;
    using System;
    using Models;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class SchoolTest
    {
        private School testSchool;
        private Student testStudent;
        private Course testCourse;

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void NullNameInConstructor()
        {
            testSchool = new School(null);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void EmptyNameInConstructor()
        {
            testSchool = new School(string.Empty);
        }

        [TestMethod]
        public void ShouldReturnCorrectName()
        {
            testSchool = new School("Telerik Software Academy");

            Assert.AreEqual<string>("Telerik Software Academy", testSchool.Name);
        }

        [TestMethod]
        public void AddStudent_ShouldAddStudentCorrectly()
        {
            testSchool = new School("1521 Special");
            testStudent = new Student("Pesho Ivanov", 12312);

            testSchool.RegisterStudent(testStudent);

            Assert.AreSame(testStudent, testSchool.Students.First());
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void AddStudent_ShouldThrowExceptionIfNullStudentPassed()
        {
            testSchool = new School("1521 Special");       
            testSchool.RegisterStudent(null);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void AddStudent_ShouldThrowExceptionIfStudentAlreadyExists()
        {
            testSchool = new School("1521 Special");
            testStudent = new Student("Pesho Ivanov", 12312);

            testSchool.RegisterStudent(testStudent);
            testSchool.RegisterStudent(testStudent);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AddStudent_ShouldThrowExceptionIfStudentIdNotInRange()
        {
            testSchool = new School("1521 Special");
            testStudent = new Student("Pesho Ivanov", 1231222);

            testSchool.RegisterStudent(testStudent);
        }

        [TestMethod]
        public void AddCourse_ShouldAddCourseCorrectly()
        {
            testSchool = new School("Test school");
            testCourse = new Course("Botanics");        
            testSchool.CreateCourse(testCourse);

            Assert.AreSame(testCourse, testSchool.Courses.First());
        }
   
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void AddCourse_ShouldThrowExceptionIfNullCoursePassed()
        {
            testSchool = new School("1521 Special23");
            testSchool.CreateCourse(null);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void AddCourse_ShouldThrowExceptionIfCourseAlreadyExists()
        {
            testSchool = new School("1521 Special");
            testCourse = new Course("Mathematics");

            testSchool.CreateCourse(testCourse);
            testSchool.CreateCourse(testCourse);      
        }

        [TestMethod]
        public void UnregisterStudent_ShouldRemoveStudentCorrectly()
        {
            testSchool = new School("1521 Special");
            testSchool.Students.Add(new Student("Asdasd", 12322));

           
        }           
    }
}
