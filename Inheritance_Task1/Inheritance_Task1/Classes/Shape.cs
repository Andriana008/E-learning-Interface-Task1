﻿using System;
namespace Inheritance_Task1
{
    public abstract class Shape
    {
        protected double contourWidth;

        public Color ContourColor { get; set; }
        public Color FillingColor { get; set; }
        public double ContourWidth
        {
            get
            {
                return contourWidth;
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Negative width");
                }
                contourWidth = value;
            }
        }

        protected Shape(Color color1 = Color.White, Color color2 = Color.White, double width = 0.0)
        {
            this.ContourColor = color1;
            this.FillingColor = color2;
            this.ContourWidth = width;
        }

        public override string ToString()
        {
            return $"ContourColor:{this.ContourColor}\nFillingColor:{this.FillingColor}\nContourWidth:{this.ContourWidth}\n";
        }

        public abstract double Area();
        public abstract double Perimeter();
        public abstract double Volume();

    }
}
