using System;
using System.Collections.Generic;
using System.Text;

namespace Curso2
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }



       public Pessoa MaisVelho(Pessoa p1, Pessoa p2)
        {
            if (p1.Salary > p2.Salary)
                return p1;
            return p2;
        }

        public void IncreaseSalary(double percentagem)
        {

        }



        public override string ToString()
        {
            return "Id = " +Id + "\nNome = " +Name+"\n Salario = " + Salary ;
        }
    }
}
