using System;
namespace Inheritance_Task1
{
    public class Cylinder:Circle
    {
        public double Height { get; set; }

        public Cylinder(Color color1 = Color.White, Color color2 = Color.White, double width = 1, double radius = 1, double height = 1)
            : base(color1, color2, width,radius)
        {         
            this.Height = height;
            if (Height.Equals(0))
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
            Console.WriteLine("Height:{0}", Height);
        }
        public override double Volume()
        {
            return Math.PI * Math.Pow(Radius, 2) * Height;
        }
        public override string GetType()
        {
            return "Cylinder";
        }
    }
}
