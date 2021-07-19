using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Radius { get; set; }

        public override double CalculateArea() => Math.PI * radius * radius;

        public override double CalculatePerimeter() => 2 * Math.PI * radius;

        public override string Draw() => base.Draw() + this.GetType().Name;
    }
}
