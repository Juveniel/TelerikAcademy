using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _03.AppearanceCountTest;

namespace _03.AppearanceCountTest
{
    [TestClass]
    public class AppearanceCountTest
    {
        [TestMethod]
        public void TestNumberCount()
        {
            int[] testArr = { 1, 1, 2, 3, 3, 1, 1, 1 };

            int actual = AppearanceCount.AppearanceCount.CountNumberAppearance(testArr, 1);
            int expected = 5;

            Assert.AreEqual(expected, actual);
        }
    }
}
