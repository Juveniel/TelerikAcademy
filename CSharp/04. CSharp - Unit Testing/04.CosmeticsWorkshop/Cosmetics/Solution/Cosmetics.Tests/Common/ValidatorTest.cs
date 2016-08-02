namespace Cosmetics.Tests.Common
{
    using System;
    using Cosmetics.Common;
    using Cosmetics.Products;
    using NUnit.Framework;
   
    [TestFixture]
    public class ValidatorTest
    {
        [Test]
        public void CheckIfNull_ShouldThrowNullReferenceEception_WhenParameterIsNull()
        {
            // Arrange
            object testObj = null;

            // Act & Assert
            Assert.Throws<NullReferenceException>(() => Validator.CheckIfNull(testObj));
        }

        [Test]
        public void CheckIfNull_ShouldNotThrowAnyExceptions_WhenParameterIsNotNull()
        {
            // Arrange
            var testObj = new Shampoo("Wash&Go", "JJT", 12.50M, GenderType.Unisex, 150, UsageType.EveryDay);

            // Act & Assert
            Assert.DoesNotThrow(() => Validator.CheckIfNull(testObj));
        }

        [Test]
        [TestCase("")]
        [TestCase(null)]
        public void CheckIfStringIsNullOrEmpty_ShouldThrowNullReferenceException_WhenParameterIsNullOrEmpty(
            string text)
        {
            // Act & Assert
            Assert.Throws<NullReferenceException>(() => Validator.CheckIfStringIsNullOrEmpty(text));
        }

        [Test]
        [TestCase("asdasd")]
        [TestCase("a")]
        public void CheckIfStringIsNullOrEmpty_ShouldNotThrowNullReferenceException_WhenParameterIsNotNullOrEmpty(string text)
        {
            // Act & Assert
            Assert.DoesNotThrow(() => Validator.CheckIfStringIsNullOrEmpty(text));
        }

        [Test]
        [TestCase("12345", 1, 4)]
        [TestCase("12345", 6, 10)]
        [TestCase("1", 2, 5)]
        public void CheckIfStringLengthIsValid_ShouldThrowIndexOutOfRangeException_WhenParameterNotInRange(
            string text, 
            int minRange, 
            int maxRange)
        {
            // Act & Assert
            Assert.Throws<IndexOutOfRangeException>(
                () => Validator.CheckIfStringLengthIsValid(text, maxRange, minRange));
        }

        [Test]
        [TestCase("12345", 1, 6)]
        [TestCase("12345", 1, 5)]
        public void CheckIfStringLengthIsValid_ShouldNotThrowException_WhenParameterIsInRange(
            string text, 
            int minRange,
            int maxRange)
        {
            // Act & Assert
            Assert.DoesNotThrow(() => Validator.CheckIfStringLengthIsValid(text, maxRange, minRange));
        }
    }
}
