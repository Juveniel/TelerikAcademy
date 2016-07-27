namespace School.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;  
    using System;
    using System.Linq;
    using Models;

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
            this.testSchool = new School("Test school");
            this.testCourse = new Course("Botanics");        
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
            testSchool = new School("15213 Special");
            testStudent = new Student("Asdasd", 12312);

            testSchool.RegisterStudent(testStudent);
            testSchool.UnregisterStudent(testStudent);

            Assert.IsTrue(!testSchool.Students.Any());
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void UnregisterStudent_ShouldThrowExceptionIfNull()
        {
            testSchool = new School("1521 Special");
            testSchool.UnregisterStudent(null);
        }

        [ExpectedException(typeof(InvalidOperationException))]
        public void UnregisterStudent_ShouldThrowExceptionIfNotExisting()
        {
            testSchool = new School("1521 Special");
            testStudent = new Student("Asdasd", 12322);

            testSchool.UnregisterStudent(testStudent);
        }

        [TestMethod]
        public void RemoveCourse_ShouldRemoveCourseCorrectly()
        {
            testSchool = new School("1521 Special");
            testCourse = new Course("Biology");

            testSchool.CreateCourse(testCourse);
            testSchool.RemoveCourse(testCourse);

            Assert.IsTrue(!testSchool.Courses.Any());
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void RemoveCourse_ShouldThrowExceptionIfNull()
        {
            testSchool = new School("1521");

            testSchool.RemoveCourse(null);
        }

        [ExpectedException(typeof(InvalidOperationException))]
        public void RemoveCourse_ShouldThrowExceptionIfNotExisting()
        {
            testSchool = new School("1521 Special");
            testCourse = new Course("QA");

            testSchool.RemoveCourse(testCourse);
        }
    }
}
