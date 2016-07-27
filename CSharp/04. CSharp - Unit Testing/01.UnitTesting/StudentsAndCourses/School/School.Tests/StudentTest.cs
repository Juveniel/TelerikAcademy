namespace School.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Models;
    using System;
    using System.Linq;
   
    [TestClass]
    public class StudentTest
    {
        private School testSchool;
        private Student testStudent;
        private Course testCourse;

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void NullNameInConstructor()
        {
            testStudent = new Student(null, 10000);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void EmptyNameInConstructor()
        {
            testStudent = new Student(string.Empty, 10000);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void StudentShouldThrowArgumentExceptionForInvalidIdBelowMinValue()
        {
            testStudent = new Student("Ivancho Petrov", 5);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void StudentShouldThrowArgumentExceptionForInvalidIdAboveMaxValue()
        {
            testStudent = new Student("Ivancho Petrov", 123213132);
        }

        [TestMethod]
        public void ShouldCreateStudentCorrectly()
        {
            testStudent = new Student("Ivancho Petrov", 10000);

            Assert.AreEqual("Ivancho Petrov", testStudent.Name);
            Assert.AreEqual(10000, testStudent.Id);
        }

        [TestMethod]
        public void JoinCourse_ShouldAddStudentToCourseCorrectly()
        {
            testStudent = new Student("Gosho Goshev", 10000);
            testCourse = new Course("Theology");        
            testStudent.JoinCourse(testCourse);
        
            Assert.AreSame(testStudent, testCourse.Students.First());
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void JoinCourse_ShouldThrowExceptionIfNull()
        {
            testStudent = new Student("Gosho Goshev", 10000);
            testStudent.JoinCourse(null);
        }

        [TestMethod]
        public void LeaveCourse_ShouldRemoveStudentFromCourseCorrectly()
        {
            testStudent = new Student("Gosho Ivanov", 10000);
            testCourse = new Course("Theology2");

            testStudent.JoinCourse(testCourse);
            testStudent.LeaveCourse(testCourse);

            Assert.IsTrue(!testCourse.Students.Any());
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void LeaveCours_ShouldThrowExceptionIfNull()
        {
            testStudent = new Student("Gosho Goshev", 10000);
            testStudent.LeaveCourse(null);
        }
    }
}
