using _45_2_Funcionario;

Funcionario funcionario = new Funcionario();

Console.Write("Digite o nome do funcionario: ");
funcionario.Nome = Console.ReadLine();
Console.WriteLine();

Console.Write($"Digite o Salário de {funcionario.Nome}: ");
funcionario.SalarioBruto = double.Parse(Console.ReadLine());
Console.WriteLine();

Console.Write("Digite o valor de desconto referente ao imposto: ");
funcionario.Imposto = double.Parse(Console.ReadLine());
Console.WriteLine();

Console.WriteLine("Dados do funcionario: ");
Console.WriteLine();
Console.WriteLine(funcionario);

Console.WriteLine();
Console.Write("Digite um percentual de aumento para o funcionário: ");
int porcentagemAumento = int.Parse(Console.ReadLine());
Console.WriteLine();

funcionario.AumentarSalario(porcentagemAumento);
Console.WriteLine();

Console.WriteLine("Dados atualizados: ");
Console.WriteLine(funcionario);