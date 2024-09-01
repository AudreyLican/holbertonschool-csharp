using System;
using MyMath;
using NUnit.Framework;

namespace MyMath.Tests
{
    /// <summary>
    /// Unit Test
    /// </summary>
    [TestFixture]
    public class OperationsTests
    {
        [Test]
        public void Max_NonEmptyList_ReturnsMaxValue()
        {
            // Arrange
            List<int> nums = new List<int> { 1, 3, 7, 2, 5 };
            int expected = 7;

            // Act
            int result = Operations.Max(nums);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Max_EmptyList_ReturnsZero()
        {
            // Arrange
            List<int> nums = new List<int>();

            // Act
            int result = Operations.Max(nums);

            // Assert
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Max_ListWithNegativeNumbers_ReturnsMaxValue()
        {
            // Arrange
            List<int> nums = new List<int> { -10, -3, -5, -7 };
            int expected = -3;

            // Act
            int result = Operations.Max(nums);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Max_ListWithOneElement_ReturnsThatElement()
        {
            // Arrange
            List<int> nums = new List<int> { 42 };
            int expected = 42;

            // Act
            int result = Operations.Max(nums);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Max_NullList_ReturnsZero()
        {
            // Act
            int result = Operations.Max(null);

            // Assert
            Assert.AreEqual(0, result);
        }
    }
}
