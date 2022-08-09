using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _042_PrecoDoProduto
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;



        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantity)
        {
            Quantidade += quantity;
        }

        public void RemoverProduto(int quantity)
        {
            Quantidade -= quantity;
        }

        
    }
}
