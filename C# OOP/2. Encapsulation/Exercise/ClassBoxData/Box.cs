using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBoxData
{
    public class Box
    {
        private double length;
        private double width;
        private double height;
        private const string ZeroOrNegativeArgumentException = "{0} cannot be zero or negative.";
        public Box(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }
        public double Length
        {
            get
            {
                return length;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(String.Format(ZeroOrNegativeArgumentException, nameof(Length)));
                }
                length = value;
            }
        }

        public double Width
        {
            get
            {
                return width;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(String.Format(ZeroOrNegativeArgumentException, nameof(Width)));
                }
                width = value;
            }
        }

        public double Height
        {
            get
            {
                return height;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(String.Format(ZeroOrNegativeArgumentException, nameof(Height)));
                }
                height = value;
            }
        }

        public double SurfaceArea()
        {
            return 2 * ((Width * Height) + (Length * Height) + (Length * Width));
        }

        public double LateralSurfaceArea()
        {
            return 2 * ((Length * Height) + (Width * Height));
        }

        public double Volume()
        {
            return Height * Width * Length;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Surface Area - {SurfaceArea():f2}");
            sb.AppendLine($"Lateral Surface Area - {LateralSurfaceArea():f2}");
            sb.AppendLine($"Volume - {Volume():f2}");

            return sb.ToString().TrimEnd();
        }
    }
}
