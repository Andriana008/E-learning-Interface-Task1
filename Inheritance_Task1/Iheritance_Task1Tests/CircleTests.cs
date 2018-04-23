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
    }
}
