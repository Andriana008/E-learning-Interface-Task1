using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Inheritance_Task1;

namespace Iheritance_Task1Tests
{
    [TestClass]
    public class CuboidTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CuboidConstructorException()
        {
            Cuboid cub = null;
            cub = new Cuboid(Color.Black, Color.Brown, 2, 4, 2, -3);
            Assert.AreEqual(cub, null);
        }

        [TestMethod]
        public void PrintTest()
        {
            Cuboid cub = new Cuboid(Color.Red, Color.Yellow, 2, 4, 7, 5);

            string excpected = "Cuboid:\nContourColor:Red\nFillingColor:Yellow\nContourWidth:2\nSideA:4\nSideB:7\nSideC:5\n";
            string actual = cub.ToString();

            Assert.AreEqual(excpected, actual);
        }

        [TestMethod]
        public void AreaTest()
        {
            Cuboid cub = new Cuboid(Color.Red, Color.Yellow, 2, 1, 2, 3);

            double expected = 22;
            double actual = cub.Area();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void VolumeTest()
        {
            Cuboid cub = new Cuboid(Color.Red, Color.Yellow, 2, 1, 2, 3);

            double expected = 6;
            double actual = cub.Volume();

            Assert.AreEqual(expected, actual);
        }
    }
}
