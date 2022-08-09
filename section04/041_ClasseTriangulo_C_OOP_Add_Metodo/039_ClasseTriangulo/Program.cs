using System.Globalization;
using ClasseTriangulo;

Triangulo x, y;
x = new Triangulo();
y = new Triangulo();

Console.WriteLine("Entre com as medidas do triângulo X: "); 
x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Entre com as medidas do triângulo Y: ");
y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double areaX = x.Area();
double areaY = y.Area();

Console.WriteLine("Area de x = "+areaX.ToString());
Console.WriteLine("Area de y = " + areaY.ToString());

if(areaX > areaY)
{
    Console.WriteLine("Maior área é do triângulo X.");
}
else
{
    Console.WriteLine("Maior área é do triângulo Y.");

}