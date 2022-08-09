using _042_PrecoDoProduto;
using System.Globalization;
Produto novoProduto = new Produto();

Console.WriteLine("Entre com o nome do Produto");

Console.Write("Nome: ");
novoProduto.Nome = Console.ReadLine();

Console.Write("Preço: ");
novoProduto.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write("Quantidade em Estoque: ");
novoProduto.Quantidade = int.Parse(Console.ReadLine());

Console.WriteLine("Dados do produto: "+ novoProduto.Nome + ", Preço $"+novoProduto.Preco + " Quantidade: "+novoProduto.Quantidade);