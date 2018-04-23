using System;
namespace Inheritance_Task1
{
    public class Rectangle:Shape
    {
        protected double sideA;
        protected double sideB;

        public double SideA
        {
            get
            {
                return sideA;
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Negative side A");
                }
                sideA = value;
            }
        }
        public double SideB
        {
            get
            {
                return sideB;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Negative side B");
                }
                sideB = value;
            }
        }


        public Rectangle(Color color1 = Color.White, Color color2 = Color.White, double width = 0,double a=0,double b=0)
            : base(color1, color2, width)
        {            
            this.SideA = a;
            this.SideB = b;
        }

        public override void Print()
        {
            Console.WriteLine("Rectangle:");
            base.Print();
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

        public override double Volume()
        {
            return 0;
        }
    }
}
