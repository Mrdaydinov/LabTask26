﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask26.Task2
{
    internal class Circle : IShape
    {
        double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }        

        public double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
