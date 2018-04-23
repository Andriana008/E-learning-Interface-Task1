using System;
namespace Inheritance_Task1
{
    public class Rectangle:Shape
    {
        public double SideA { get; set; }
        public double SideB { get; set; }


        public Rectangle(Color color1 = Color.White, Color color2 = Color.White, double width = 1,double a=1,double b=1)
            : base(color1, color2, width)
        {            
            this.SideA = a;
            this.SideB = b;
            if (SideA.Equals(0) || SideB.Equals(0))
            {
                throw new Exception("invalid data");
            }
        }

        public override void Output()
        {
            Console.WriteLine("ContourColor:{0}", ContourColor);
            Console.WriteLine("FillingColor:{0}", FillingColor);
            Console.WriteLine("ContourWidth:{0}", ContourWidth);
            Console.WriteLine("SideA:{0}", SideA);
            Console.WriteLine("SideB:{0}", SideB);
        }
        public override double Area()
        {
            return SideA * SideB;
        }

        public override double Perimeter()
        {
            return 2 * (SideB + SideA);
        }

        public override double Volume() => throw new NotImplementedException();

        public override string GetType()
        {
            return "Rectangle";
        }
    }
}
