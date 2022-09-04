// See https://aka.ms/new-console-template for more information

using cpf;

Pessoa pessoa = new Pessoa();

Console.Write("Digite o cpf da pessoa: ");
pessoa.Cpf = "063.169.969-42";

Console.WriteLine();

pessoa.Cpf = pessoa.Cpf.Replace(".", "").Replace("-", "");

int[] cpfValido = new int[] {0,6,3,1,6,9,9,6,9,4,2};

Console.WriteLine($"Cpf digitado = {cpfValido[0]*5}");

