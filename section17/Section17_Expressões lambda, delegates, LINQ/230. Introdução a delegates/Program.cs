using _230._Introdução_a_delegates;
double b = 12;
double a = 10;


BinaryNumericOperation sum = CalculationService.Sum;

Console.WriteLine("-------------------------");
double result = sum(a, b);
Console.Write("Sum: ");
Console.WriteLine(result);
Console.WriteLine("-------------------------");

BinaryNumericOperation max = CalculationService.Max;


Console.WriteLine("-------------------------");
double result2 = max(a, b);
Console.Write("Max: ");
Console.WriteLine((result2));
Console.WriteLine("-------------------------");



delegate double BinaryNumericOperation(double a, double b);