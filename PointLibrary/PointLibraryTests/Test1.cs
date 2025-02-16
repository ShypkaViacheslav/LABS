// PointLibraryTests.cs - Модульні тести для бібліотеки PointLibrary
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PointLibrary;

namespace PointLibraryTests
{
    [TestClass]
    public class Point3DTests
    {
        [TestMethod]
        public void TestDistanceToOrigin()
        {
            var point = new Point3D(3, 4, 0);
            Assert.AreEqual(5, point.DistanceToOrigin(), 0.0001);
        }

        [TestMethod]
        public void TestDistanceTo()
        {
            var point1 = new Point3D(1, 2, 3);
            var point2 = new Point3D(4, 6, 3);
            Assert.AreEqual(5, point1.DistanceTo(point2), 0.0001);
        }
    }

    [TestClass]
    public class ColoredPoint3DTests
    {
        [TestMethod]
        public void TestColorProperty()
        {
            var coloredPoint = new ColoredPoint3D(1, 2, 3, "Red");
            Assert.AreEqual("Red", coloredPoint.Color);
        }
    }
}
