using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Inheritance_Task1;
using System.Collections.Generic;

namespace Iheritance_Task1Tests
{
    [TestClass]
    public class TaskTests
    {
        [TestMethod]
        public void TotalAreaTest()
        {
            List<Shape> figures = new List<Shape>();
            figures.Add(new Cylinder(Color.Blue, Color.Pink, 3, 6, 8));
            figures.Add(new Circle(Color.Black, Color.White, 5, 2));
            figures.Add(new Rectangle(Color.Orange, Color.Pink, 1, 5, 3));
            figures.Add(new Cuboid(Color.Red, Color.Yellow, 2, 8, 3, 2));
            figures.Add(new Cylinder(Color.Blue, Color.Pink, 3, 3, 4));
            figures.Add(new Circle(Color.Black, Color.White, 1, 2));

            Task task = new Task();
            double excpected = 205.50441064025904;
            double actual = task.TotalArea(figures);

            Assert.AreEqual(excpected, actual);
        }

        [TestMethod]
        public void TotalPerimeterTest()
        {
            List<Shape> figures = new List<Shape>();
            figures.Add(new Circle(Color.Black, Color.White, 2, 6));
            figures.Add(new Rectangle(Color.Orange, Color.Pink, 3, 6, 3));
            figures.Add(new Cuboid(Color.Red, Color.Yellow, 2, 4, 7, 2));
            figures.Add(new Cylinder(Color.Blue, Color.Pink, 3, 6, 8));
            figures.Add(new Circle(Color.Black, Color.White, 5, 2));

            Task task = new Task();
            double excpected = 127.96459430051421;
            double actual = task.TotalPerimeter(figures);

            Assert.AreEqual(excpected, actual);
        }
    }
}
