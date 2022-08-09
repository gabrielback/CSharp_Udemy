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

Console.WriteLine($"Dados do produto: {novoProduto}");

Console.WriteLine();
Console.Write("Digite o número de produtos a ser adicionado: ");
int qte = int.Parse(Console.ReadLine());
novoProduto.AdicionarProdutos(qte);

Console.WriteLine();
Console.WriteLine($"Dados atualizados: {novoProduto}");

Console.WriteLine();
Console.Write("Digite o número de produtos a ser removido: ");
qte = int.Parse(Console.ReadLine());
novoProduto.RemoverProduto(qte);

Console.WriteLine();
Console.WriteLine($"Produtos removidos e atualizados: {novoProduto}");