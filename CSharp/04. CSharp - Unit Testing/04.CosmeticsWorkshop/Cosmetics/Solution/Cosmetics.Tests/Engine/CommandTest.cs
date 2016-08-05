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
            const string CommandName = "CreateCategory";

            // Act & assert
            Assert.DoesNotThrow(() => Command.Parse(CommandName));
        }

        [Test]
        public void Parse_ShouldSetCorrectCommandProperties_WhenInputStringIsValid()
        {
            // Arrange
            const string CommandInput = "CreateCategory param1";

            // Act
            var command = Command.Parse(CommandInput);

            // Assert
            Assert.AreEqual("CreateCategory", command.Name);
            Assert.AreEqual("param1", command.Parameters[0]);
        }

        [Test]
        public void Parse_ShouldThrowArgumentNullException_WhenCommandNameIsNull()
        {
            // Arrange
            const string CommandInput = " param1 param2";

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => Command.Parse(CommandInput), "Name");
        }

        [Test]
        public void Parse_ShouldThrowArgumentNullException_WhenCommandParametersAreNullOrEmpty()
        {
            // Arrange
            const string CommandInput = "CreateCategory ";

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => Command.Parse(CommandInput), "List");
        }
    }
}
