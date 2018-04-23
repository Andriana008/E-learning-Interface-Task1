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
    }
}
