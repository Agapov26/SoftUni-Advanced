using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Circle : Shape
    {
        public Circle(double radius, double height, double width) : base(height, width)
        {
            this.Radius = radius;
            this.Height = height;
            this.Width = width;
        }
        public double Radius { get; private set; }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius;
        }

        public override string Draw()
        {
            return "Circle";
        }
    }
}
