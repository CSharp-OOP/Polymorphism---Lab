using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Rectangle : Shape
    {
        private double height;
        private double width;

        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
        }

        public double Height { get; set; }
        public double Width { get; set; }

        public override double CalculateArea() => Height * Width;

        public override double CalculatePerimeter() => 2 * (Height + Width);

        public override string Draw() => base.Draw() + this.GetType().Name;
    }
}
