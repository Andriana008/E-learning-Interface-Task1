using System;

namespace Inheritance_Task1
{
    public class Circle:Shape
    {
        protected double radius;

        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Negative radius");
                }
                radius = value;
            }
        }

        public Circle(Color color1 = Color.White, Color color2 = Color.White, double width = 0, double radius = 0)
            : base(color1, color2, width)
        {
            this.Radius = radius;
        }

        public override string ToString()
        {
            return $"Circle:\n{base.ToString()}Radius:{this.Radius}\n";
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public override double Perimeter()
        {
            return Math.PI * 2 * Radius;
        }

        public override double Volume()
        {
            return 0;
        }
    }

}
