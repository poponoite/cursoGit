using System;
using System.Collections.Generic;
using System.Text;

namespace Curso2
{
    class ConversorDeMoeda
    {
        public static double dolar;

        public static double converter(double valor)
        {
            var resultado = valor * dolar;
            return  resultado + (resultado * 6 / 100) ;
        }
    }
}
