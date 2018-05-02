using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Inheritance_Task1;

namespace Iheritance_Task1Tests
{
    [TestClass]
    public class RectangleTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void RectangleConstructorException()
        {
            Rectangle rect= null;
            rect = new Rectangle(Color.Black, Color.Brown, 2, 4, -1);
            Assert.AreEqual(rect, null);
        }

                [TestMethod]
        public void PrintTest()
        {
            Rectangle rect = new Rectangle(Color.Red, Color.Yellow, 2, 4, 7);

            string excpected = "Rectangle:\nContourColor:Red\nFillingColor:Yellow\nContourWidth:2\nSideA:4\nSideB:7\n";
            string actual = rect.ToString();

            Assert.AreEqual(excpected, actual);
        }

        [TestMethod]
        public void AreaTest()
        {
            Rectangle rect = new Rectangle(Color.Red, Color.Yellow, 2, 1, 2);

            double expected = 2;
            double actual = rect.Area();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void VolumeTest()
        {
            Rectangle rect = new Rectangle(Color.Red, Color.Yellow, 2, 2, 3);

            double expected = 0;
            double actual = rect.Volume();

            Assert.AreEqual(expected, actual);
        }
    }
}
