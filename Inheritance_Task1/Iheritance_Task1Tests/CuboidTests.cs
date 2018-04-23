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
    }
}
