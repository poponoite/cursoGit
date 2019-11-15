using System;
using System.Collections.Generic;
using System.Text;

namespace Curso2
{
    public class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }
        public double Total { get; set; }


        public void ValorTotalEmEstoque()
        {
             Console.WriteLine($"Nome produto: {Nome} \nPreco: {Preco}\nQuantidade: {Quantidade}\nTotal: {Total = (Quantidade * Preco) }");
        }

        public void AdicionarProduto(int quantidade)
        {
            Quantidade += quantidade ;
            
            ValorTotalEmEstoque();
        }

        public void RemoverProduto()
        {
            Quantidade--;
    
            ValorTotalEmEstoque();
        }

        public override string ToString()
        {
            return Nome + Preco + Quantidade;
        }
    }
}
