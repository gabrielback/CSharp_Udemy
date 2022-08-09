using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

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


        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProduto(int quantity)
        {
            Quantidade -= quantity;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}," +
                $" Preço: ${Preco.ToString("F2", CultureInfo.InvariantCulture)}," +
                $" Quantidade: {Quantidade}," +
                $" Total em estoque: ${ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}";
        }

        
    }
}
