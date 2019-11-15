using System;
using System.Collections.Generic;
using System.Text;

namespace Curso2
{
    class Aluno
    {
        private string _nome;
        private double Preco
        {
            get
            {
                return Preco;
            }

            set
            {
                if (Preco > 0 )
                {
                    Preco = value;
                }
            }
        }
        public double N2 { get; set; }
        public double N3 { get; set; }


        public string GetNome()
        {
            return _nome;
        }

        public void SetNome(String nome)
        {
            if (String.IsNullOrEmpty(nome) && nome.Length > 0)
            {
                _nome = nome;
            }
        }

        public Aluno() { }

        public Aluno(double N1, double N2, double N3)
        {
         
            this.N2 = N2;
            this.N3 = N3;
        }

        public string Aprovado(double N1, double N2, double N3)
        {
            double soma = N1 + N2 + N3;
            if (soma > 60)
            {
                return $"Nota Final = {soma} \nAprovado";
            }
            else
            {
                double falta = 60 - soma;
                return $"Nota final = {soma} Reprovado, faltaram" + falta + "Pts";

            }
            
        }
    }
}
