using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Inheritance_Task1;

namespace Iheritance_Task1Tests
{
    [TestClass]
    public class CylinderTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CylinderConstructorException()
        {
            Cylinder cyl = null;
            cyl = new Cylinder(Color.Black, Color.Brown, 2, 4, -1);
            Assert.AreEqual(cyl, null);
        }

        [TestMethod]
        public void PrintTest()
        {
            Cylinder cyl = new Cylinder(Color.Blue, Color.Pink, 2, 4, 6);

            string excpected = "Cylinder:\nContourColor:Blue\nFillingColor:Pink\nContourWidth:2\nRadius:4\nHeight:6\n";
            string actual = cyl.ToString();

            Assert.AreEqual(excpected, actual);
        }

        [TestMethod]
        public void AreaTest()
        {
            Cylinder cyl = new Cylinder(Color.Red, Color.Yellow, 2, 3, 6);

            double expected = 169.64600329384882;
            double actual = cyl.Area();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void VolumeTest()
        {
            Cylinder cyl = new Cylinder(Color.Red, Color.Yellow, 2, 3, 6);

            double expected = 169.64600329384882;
            double actual = cyl.Volume();

            Assert.AreEqual(expected, actual);
        }
    }
}
