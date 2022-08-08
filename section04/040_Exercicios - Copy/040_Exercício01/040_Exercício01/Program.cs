using _040_Exercício01;

/*
 * Exercício Proposto
 * 
 * Escreva um programa que receba o nome e idade de duas pessoas e retorne a pessoa mais velha.
 */

Pessoa pessoa1, pessoa2;
pessoa1 = new Pessoa();
pessoa2 = new Pessoa();

Console.WriteLine("Digite o nome da primeira pessoa: ");
pessoa1.Nome = Console.ReadLine();
Console.WriteLine("Digite a idade de "+pessoa1.Nome);
pessoa1.Idade = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o nome da segunda pessoa: ");
pessoa2.Nome = Console.ReadLine();
Console.WriteLine("Digite a idade de "+pessoa2.Nome);
pessoa2.Idade = int.Parse(Console.ReadLine());

if(pessoa1.Idade > pessoa2.Idade)
{
    Console.WriteLine(pessoa1.Nome + " é mais velho que " + pessoa2.Nome);
}
else
{
    Console.WriteLine(pessoa2.Nome + " é mais velho que " + pessoa1.Nome);
}

