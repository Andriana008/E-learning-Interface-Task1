using System;
namespace Inheritance_Task1
{
    public class Cuboid:Rectangle
    { 
        public double SideC { get; set; }

        public Cuboid(Color color1 = Color.White, Color color2 = Color.White, double width = 1, double a = 1, double b = 1, double c = 1)
            : base(color1, color2, width, a, b)
        {
            this.SideC = c;
            if (SideC.Equals(0))
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
            Console.WriteLine("SideC:{0}", SideC);
        }
		public override double Volume()
		{
            return SideC * SideB * SideA;
		}
        public override string GetType()
        {
            return "Cuboid";
        }
	}
}
