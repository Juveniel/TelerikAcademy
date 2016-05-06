using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _01.SayHello;

namespace _01.SayHelloTest
{
    [TestClass]
    public class SayHelloTest
    {
        [TestMethod]
        public void TestGreeting()
        {
            string actual = SayHello.SayHello.GreetPerson("Pesho");
            string expected = "Hello, Pesho!";
            Assert.AreEqual(actual, expected);
        }
    }
}
    