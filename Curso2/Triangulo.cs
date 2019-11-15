using System;
using System.Collections.Generic;
using System.Text;

namespace Curso2
{
    class Triangulo
    {
        public double  A{ get; set; }
        public double  B{ get; set; }
        public double  C{ get; set; }


        public double Area(double a, double  b, double c)
        {
            double p = (a + b + c) / 2.0;
            double area =  Math.Sqrt(p * (a * p) * (b * p) * (c * p));

            return area;
        }
    }
}
