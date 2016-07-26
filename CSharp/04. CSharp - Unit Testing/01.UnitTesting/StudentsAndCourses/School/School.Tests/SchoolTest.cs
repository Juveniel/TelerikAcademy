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
        public void SchoolShouldReturnCorrectName()
        {
            testSchool = new School("Telerik Software Academy");

            Assert.AreEqual<string>("Telerik Software Academy", testSchool.Name);
        }

        [TestMethod]
        public void ShouldAddStudentCorrectly()
        {
            testSchool = new School("1521 Special");
            testStudent = new Student("Pesho Ivanov", 12312);

            testSchool.RegisterStudent(testStudent);

            Assert.AreSame(testStudent, testSchool.Students.First());
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void ShouldThrowExceptionIfNullStudentPassed()
        {
            testSchool = new School("1521 Special");       
            testSchool.RegisterStudent(null);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void ShouldThrowExceptionIfStudentAlreadyExists()
        {
            testSchool = new School("1521 Special");
            testStudent = new Student("Pesho Ivanov", 12312);

            testSchool.RegisterStudent(testStudent);
            testSchool.RegisterStudent(testStudent);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ShouldThrowExceptionIfStudentIdNotInRange()
        {
            testSchool = new School("1521 Special");
            testStudent = new Student("Pesho Ivanov", 1231222);

            testSchool.RegisterStudent(testStudent);
        }


    }
}
