using System;
using System.Collections.Generic;
using System.Text;

namespace Curso2
{
    class Calculadora
    {
        public static double Pi = 3.14;


        public static int somar(params int[] numbers)
        {
            var soma = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
               soma += numbers[i];
            }

            return soma;
        }

        public static double sum(params int[] numbers)
        {
            var sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }

        public static double soma(double n1, double n2)
        {
            return n1 + n2;
        }

        public static double Circunferencia(double r)
        {
            return 2.0 * Pi * r;
        }

        public static double Volume(double r)
        {
            return 4.0  / 3.0 * Pi * r * r * r;
        }

    }
}
