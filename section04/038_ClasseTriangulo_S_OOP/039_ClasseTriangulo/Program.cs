﻿using System;
using System.Globalization;

double xA, xB, xC, yA, yB, yC;

Console.WriteLine("Entre com as medidas do triângulo X: ");
xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Entre com as medidas do triângulo Y: ");
yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//teste comentario
double p = (xA+xB+xC)/2;
double areaX = Math.Sqrt(p*(p-xA)*(p-xB)*(p-xC));

p = (yA+yB+yC)/2;
double areaY = Math.Sqrt(p*(p-yA)*(p-yB)*(p-yC));


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