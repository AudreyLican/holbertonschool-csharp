using System;
using NUnit.Framework;
using MyMath;

namespace MyMath.Tests
{
    /// <summary>Unit test</summary>
    [TestFixture]
    public class OperationsTests
    {
        [Test]
        public void intIsPositive()
        {
            int a = 3;
            int b = 5;

            int result = Operations.Add(a, b);

            Assert.AreEqual(8, result);
        }

        [Test]
        public void intIsNegative()
        {
            int a = -6;
            int b = -4;

            int result = Operations.Add(a, b);

            Assert.AreEqual(-10, result);
        }

        [Test]
        public void intWithNegative()
        {
            int result = Operations.Add(8, -1);

            Assert.AreEqual(7, result);
        }

        [Test]
        public void intWithZero()
        {
            int result = Operations.Add(9, 0);
            Assert.AreEqual(9, result);
        }
    }
}