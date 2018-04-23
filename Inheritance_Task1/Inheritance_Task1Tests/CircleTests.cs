using System;
using Inheritance_Task1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Inheritance_Task1Tests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        [ExpectedException (typeof(ArgumentException))]
        public void ConstructorExceptionTest()
        {
        }
    }
}
