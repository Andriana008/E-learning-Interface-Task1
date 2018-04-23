using System;
namespace Inheritance_Task1
{
    public class Cylinder:Circle
    {
        protected double height;
        
        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                if(height < 0)
                {
                    throw new ArgumentException("Negative height");
                }
                height = value;
            }
        }

        public Cylinder(Color color1 = Color.White, Color color2 = Color.White, double width = 0, double radius = 0, double height = 0)
            : base(color1, color2, width,radius)
        {         
            this.Height = height;
        }

        public override void Print()
        {
            Console.WriteLine("Cylinder:");
            base.Print();
            Console.WriteLine("Radius:{0}", Radius);
            Console.WriteLine("Height:{0}", Height);
        }

        public override double Volume()
        {
            return Math.PI * Math.Pow(Radius, 2) * Height;
        }
    }
}
