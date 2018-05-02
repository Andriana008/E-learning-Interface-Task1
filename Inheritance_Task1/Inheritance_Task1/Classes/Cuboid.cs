using System;
namespace Inheritance_Task1
{
    public class Cuboid:Rectangle
    {
        protected double sideC;

        public double SideC
        {
            get
            {
                return sideC;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Negative side C");
                }
                sideC = value;
            }
        }

        public Cuboid(Color color1 = Color.White, Color color2 = Color.White, double width = 0, double a = 0, double b = 0, double c = 0)
            : base(color1, color2, width, a, b)
        {
            this.SideC = c;
        }

        public override string ToString()
        {
            string rectStr = base.ToString();
            rectStr = rectStr.Replace("Rectangle", "Cuboid");
            return $"{rectStr}SideC:{this.SideC}\n";
        }

        public override double Area()
        {
            return 2 * base.Area() + 2 * sideA * sideC + 2 * sideB * sideC;
        }

        public override double Volume()
		{
            return SideC * SideB * SideA;
		}
	}
}
