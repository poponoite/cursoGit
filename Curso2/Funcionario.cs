using System;
using System.Collections.Generic;
using System.Text;

namespace Curso2
{
    class Funcionario
    {
        public string Nome { get; set; }
        public double SalarioBruto { get; set; }
        public double Imposto { get; set; }


        public double SalarioLiquido(double porcentagem)
        {

            return SalarioBruto += (SalarioBruto * porcentagem / 100) - 1000;
        }

        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto += (SalarioBruto * porcentagem / 100) -1000;
        }
    }
}
