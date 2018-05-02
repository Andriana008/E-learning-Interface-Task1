using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Inheritance_Task1;

namespace Iheritance_Task1Tests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        [ExpectedException (typeof(ArgumentException))]
        public void CircleConstructorException()
        {
            Circle circle = null;
            circle = new Circle(Color.Black, Color.Blue, 2, -2);
            Assert.AreEqual(circle, null);
        }

        [TestMethod]
        public void PrintTest()
        {
            Circle circ = new Circle(Color.Red, Color.Yellow, 2, 4);

            string excpected = "Circle:\nContourColor:Red\nFillingColor:Yellow\nContourWidth:2\nRadius:4\n";
            string actual = circ.ToString();

            Assert.AreEqual(excpected, actual);
        }

        [TestMethod]
        public void AreaTest()
        {
            Circle circ = new Circle(Color.Red, Color.Yellow, 2, 3);

            double expected = 28.274333882308138;
            double actual = circ.Area();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void VolumeTest()
        {
            Circle circ = new Circle(Color.Red, Color.Yellow, 2, 3);

            double expected = 0;
            double actual = circ.Volume();

            Assert.AreEqual(expected, actual);
        }
    }
}
