namespace School.Tests
{
    using System;
    using Models;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class SchoolTest
    {
        [TestMethod]
        public void SchoolShouldReturnCorrectName()
        {
            var school = new School("Telerik Software Academy");

            Assert.AreEqual("Telerik Software Academy", school.Name);
        }    
    }
}
