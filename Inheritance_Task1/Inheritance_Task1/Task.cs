using System;
using System.Collections.Generic;

namespace Inheritance_Task1
{
    public class Task
    {
        public double TotalArea(List<Shape> list)
        {
            double res = 0;
            for (int i = 0; i < list.Count; i++)
            {
                res += list[i].Area();
            }
            return res;
        }

        public double TotalPerimeter(List<Shape> list)
        {
            double res = 0;
            for (int i = 0; i < list.Count; i++)
            {
                res += list[i].Perimeter();
            }
            return res;
        }

        public List<Shape> GetBaseShapes()
        {
            List<Shape> figures = new List<Shape>();
            figures.Add(new Circle(Color.Black, Color.White, 2, 6));
            figures.Add(new Rectangle(Color.Orange, Color.Pink, 3, 6, 3));
            figures.Add(new Cuboid(Color.Red, Color.Yellow, 2, 4, 7, 2));
            figures.Add(new Cylinder(Color.Blue, Color.Pink, 3, 6, 8));
            figures.Add(new Circle(Color.Black, Color.White, 5, 2));
            figures.Add(new Rectangle(Color.Orange, Color.Pink, 1, 5, 3));
            figures.Add(new Cuboid(Color.Red, Color.Yellow, 2, 8, 3, 2));
            figures.Add(new Cylinder(Color.Blue, Color.Pink, 3, 3, 4));
            figures.Add(new Circle(Color.Black, Color.White, 1, 2));
            figures.Add(new Rectangle(Color.Orange, Color.Pink, 1, 2, 7));
            figures.Add(new Cuboid(Color.Red, Color.Yellow, 3, 8, 4, 4));
            figures.Add(new Cylinder(Color.Blue, Color.Pink, 2, 3, 5));
            return figures;
        }

        public void OutputShapes(List<Shape> figures)
        {
            Console.WriteLine("Shapes in the list");
            for (int i = 0; i < figures.Count; i++)
            {
                Console.WriteLine("{0}: ", figures[i].GetType());
                figures[i].Output();
                Console.WriteLine();
            }  
        }

        public void DoTask()
        {
            List<Shape> shapes = GetBaseShapes();
            OutputShapes(shapes);

            Console.WriteLine("Total Area of the shapes");
            Console.WriteLine(TotalArea(shapes));
            Console.WriteLine("Total Perimeter of the shapes");
            Console.WriteLine(TotalPerimeter(shapes));
        }
    }
}
