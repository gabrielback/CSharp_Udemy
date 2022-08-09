using _45_2_Funcionario;

Funcionario funcionario = new Funcionario();

Console.Write("Digite o nome do funcionario: ");
funcionario.Nome = Console.ReadLine();
Console.WriteLine();

Console.Write("Digite o Salário do funcionário: ");
funcionario.SalarioBruto = double.Parse(Console.ReadLine());
Console.WriteLine();

Console.Write("Digite o valor do imposto em percentual: ");
funcionario.Imposto = double.Parse(Console.ReadLine());
Console.WriteLine();

Console.WriteLine("Dados do funcionario: ");
Console.WriteLine(funcionario);

Console.WriteLine("Digite um percentual de aumento para o funcionário");
int porcentagemAumento = int.Parse(Console.ReadLine());
funcionario.AumentarSalario(porcentagemAumento);
Console.WriteLine("Dados atualizados: ");
Console.WriteLine(funcionario);