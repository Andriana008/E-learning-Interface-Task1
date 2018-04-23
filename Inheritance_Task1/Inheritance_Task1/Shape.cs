using System;
namespace Inheritance_Task1
{
    public enum Color
    {
        Red,
        Green,
        Blue,
        White,
        Black,
        Yellow,
        Orange,
        Pink,
        Brown
    }

    public abstract class Shape
    {
        public Color ContourColor { get; set; }
        public double ContourWidth { get; set; }
        public Color FillingColor { get; set; }

        protected Shape(Color color1 = Color.White, Color color2 = Color.White, double width = 0.0)
        {
            this.ContourColor = color1;
            this.FillingColor = color2;
            this.ContourWidth = width;
        }

        public abstract void Output();
        public abstract double Area();
        public abstract double Perimeter();
        public abstract double Volume();
        public abstract new string GetType();

    }
}
