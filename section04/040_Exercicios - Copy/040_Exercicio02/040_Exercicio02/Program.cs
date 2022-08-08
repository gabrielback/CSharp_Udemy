using _040_Exercicio02;

Funcionario funcionario1, funcionario2;
funcionario1 = new Funcionario();
funcionario2 = new Funcionario();

Console.WriteLine("Digite o nome do primeiro funcionário");
funcionario1.Nome = Console.ReadLine();
Console.WriteLine("Digite o salário de " + funcionario1.Nome);
funcionario1.Salario = double.Parse(Console.ReadLine());



Console.WriteLine("Digite o nome do segundo funcionário");
funcionario2.Nome = Console.ReadLine();
Console.WriteLine("Digite o salário de " + funcionario2.Nome);
funcionario2.Salario = double.Parse(Console.ReadLine());

double mediaSalarial = (funcionario1.Salario + funcionario2.Salario) / 2;
Console.WriteLine($"A média salarial de {funcionario1.Nome} e {funcionario2.Nome} é de: {mediaSalarial}");