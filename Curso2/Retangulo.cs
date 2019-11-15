using System;
using System.Collections.Generic;
using System.Text;

namespace Curso2
{
    class Retangulo
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public double Area()
        {
            double area;
            return area = Base * Altura;
        }

        public double Perimetro()
        {
            double perimetro;
            return perimetro = 2 * (Base * Altura);
        }

        public double Diagonal()
        {
            double diagonal;
            return  diagonal = Math.Sqrt(Math.Pow(Base,2) + Math.Pow(Altura, 2));
        }
    }
}
