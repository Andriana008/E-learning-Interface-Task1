using System;

namespace Inheritance_Task1
{
    public class Circle:Shape
    {
        public double Radius { get; set; }

        public Circle(Color color1 = Color.White, Color color2 = Color.White, double width = 1, double radius = 1)
            : base(color1, color2, width)
        {
            this.Radius = radius;
            if (radius.Equals(0))
            {
                throw new Exception("invalid data");
            }
        }

        public override void Output()
        {
            Console.WriteLine("ContourColor:{0}", ContourColor);
            Console.WriteLine("FillingColor:{0}", FillingColor);
            Console.WriteLine("ContourWidth:{0}", ContourWidth);
            Console.WriteLine("Radius:{0}", Radius);
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

        public override string GetType()
        {
            return "Circle";
        }
    }

}
