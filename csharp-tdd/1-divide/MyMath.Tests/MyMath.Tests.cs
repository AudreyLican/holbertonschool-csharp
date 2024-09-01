using System;
using NUnit.Framework;
using MyMath;

namespace MyMath.Tests
{
    /// <summary>Unit Test</summary>
    [TestFixture]
    public class MatrixTests
    {
        [Test]
        public void Divide_ValidMatrixAndNumber_ReturnsCorrectMatrix()
        {
            // Arrange
            int[,] matrix = new int[,] { { 4, 8 }, { 16, 32 } };
            int num = 4;
            int[,] expected = new int[,] { { 1, 2 }, { 4, 8 } };

            // Act
            int[,] result = Matrix.Divide(matrix, num);

            // Assert
            CollectionAssert.AreEqual(expected, result);
        }

        [Test]
        public void Divide_MatrixIsNull_ReturnsNull()
        {
            // Act
            int[,] result = Matrix.Divide(null, 4);

            // Assert
            Assert.IsNull(result);
        }

        [Test]
        public void Divide_NumberIsZero_ReturnsNullAndPrintsError()
        {
            // Arrange
            int[,] matrix = new int[,] { { 4, 8 }, { 16, 32 } };

            // Act
            int[,] result = Matrix.Divide(matrix, 0);

            // Assert
            Assert.IsNull(result);
        }
    }
}
