using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace homework.Tests
{
    [TestClass]
    public class TriangleTests
    {
        readonly Point P = new Point(1, 1);
        readonly Point Q = new Point(1, 4);
        readonly Point L = new Point(4, 7);

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Triangle does not exist.")]
        public void InvalidVerticesInConstructor()
        {
            new Triangle(new Point(1, 1), new Point(1, 4), new Point(1, 5));
        }

        [TestMethod]
        public void Distance_QandP_3returned()
        {
            // Arrange
            double expected = 3;

            // Actual
            double actual = Math.Round(new Triangle().Distance(Q, P), 0);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Perimeter_PQL_rounded14returned()
        {
            // Arrange
            double expected = 14;

            // Actual
            double actual = Math.Round(new Triangle(P, Q, L).Perimeter());

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Square_PQL_rounded4returned()
        {
            // Arrange
            double expected = 4;

            // Actual
            double actual = Math.Round(new Triangle(P, Q, L).Square());

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
