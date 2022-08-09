/* 
 * Fazer um programa para ler os valores da largura e altura de um retângulo. Em
    seguida, mostrar na tela o valor de sua área, perímetro e diagonal. Usar uma classe
    como mostrado no projeto ao lado.
*/

using _045_1_ClasseRetangulo;
using System.Globalization;

Retangulo retangulo = new Retangulo();

Console.Write("Entre com a altura do retângulo: ");
retangulo.Altura = double.Parse(Console.ReadLine());
Console.WriteLine();

Console.Write("Entre com a largura do retângulo: ");
retangulo.Largura = double.Parse(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("A area do retângulo é " + retangulo.Area().ToString("F2", CultureInfo.InvariantCulture));

Console.WriteLine();
Console.WriteLine("O perimetro do retângulo é " + retangulo.Perimetro().ToString("F2", CultureInfo.InvariantCulture));

Console.WriteLine();
Console.WriteLine("A diagonal do retângulo é " + retangulo.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
