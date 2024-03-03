using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class Shape
    {
        protected Shape(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double Width { get; protected set; }
        public double Height { get; protected set; }

        public abstract double CalculatePerimeter();
        public abstract double CalculateArea();
        public virtual string Draw()
        {
            return "";
        }
    }
}
