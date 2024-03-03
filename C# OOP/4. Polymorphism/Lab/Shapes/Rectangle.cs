using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle : Shape
    {
        public Rectangle(double height, double width) : base(height, width)
        {
            this.Width = width;
            this.Height = height;
        }
        public override double CalculateArea()
        {
            return Height * Width;
        }

        public override double CalculatePerimeter()
        {
            return 2 * (Height + Width);
        }

        public override string Draw()
        {
            return "Rectangle";
        }
    }
}
