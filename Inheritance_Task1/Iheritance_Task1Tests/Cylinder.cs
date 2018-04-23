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
    }
}
