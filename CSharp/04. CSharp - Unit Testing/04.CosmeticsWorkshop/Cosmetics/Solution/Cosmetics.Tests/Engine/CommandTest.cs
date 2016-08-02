namespace Cosmetics.Tests.Engine
{
    using System;
    using Cosmetics.Engine;
    using NUnit.Framework;

    [TestFixture]
    public class CommandTest
    {
        [Test]
        public void Prase_ShouldReturnNewCommand_WhenInputStringIsInValidFormat()
        {
            // Arrange
            const string commandName = "CreateCategory";

            // Act & assert
            Assert.DoesNotThrow(() => Command.Parse(commandName));
        }

        [Test]
        public void Parse_ShouldSetCorrectCommandProperties_WhenInputStringIsValid()
        {
            // Arrange
            const string commandInput = "CreateCategory param1";

            // Act
            var command = Command.Parse(commandInput);

            // Assert
            Assert.AreEqual("CreateCategory", command.Name);
            Assert.AreEqual("param1", command.Parameters[0]);
        }

        [Test]
        public void Parse_ShouldThrowArgumentNullException_WhenCommandNameIsNull()
        {
            // Arrange
            const string commandInput = " param1 param2";

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => Command.Parse(commandInput), "Name");
        }

        [Test]
        public void Parse_ShouldThrowArgumentNullException_WhenCommandParametersAreNullOrEmpty()
        {
            // Arrange
            const string commandInput = "CreateCategory ";

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => Command.Parse(commandInput), "List");
        }
    }
}
