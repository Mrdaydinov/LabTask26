using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask26.Task2
{
    internal class Rectangle : IShape
    {
        double Length { get; set; }
        double Width { get; set; }

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public double CalculateArea()
        {
            return Length * Width;
        }

        public double CalculatePerimeter()
        {
            return 2 * (Length + Width);
        }
    }
}
