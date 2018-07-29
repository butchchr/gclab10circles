using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gclab10
{
    class Circle
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double Radius
        {
            get
            {
                return radius;
            }
        }

        public double CalculateCircumference()
        {
            return 2 * Math.PI * radius;
        }

        public string CalculateFormattedCircumfrence()
        {
            return FormatNumber(CalculateCircumference());
        }

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public string CalculateFormattedArea()
        {
            return FormatNumber(CalculateArea());
        }

        private string FormatNumber(double x)
        {
            return Math.Round(x, 2).ToString();
        }
    }
}
