// See https://aka.ms/new-console-template for more information
Console.WriteLine("Desconto IR");

Console.WriteLine("Digite seu sálario:");
double salario = double.Parse(Console.ReadLine());

double al1 = 7.5;
double al2 = 15;
double al3 = 22.5;
double valorAliquota = salario * al1 / 100;
double valorAliquota1 = salario * al2 / 100;
double valorAliquota2 = salario * al3 / 100;
string Real = $"{valorAliquota} Reais.";
string Real1 = $"{valorAliquota1} Reais.";
string Real2 = $"{valorAliquota2} Reais.";

switch (salario)
{
    case <= 1900:
        Console.WriteLine("Você não deve IR.");
        break;
    case >= 1901 and <= 2800:
        valorAliquota = salario * al1 / 100;
        Console.WriteLine("Você deve pagar uma aliquota de 7,5%.");
        Console.WriteLine($"Valor a ser pago é de = {Real}");
        break;
    case >= 2801 and <= 3751:
        valorAliquota1 = salario * al2 / 100;
        Console.WriteLine("Você deve pagar uma aliquota de 15%.");
        Console.WriteLine($"Valor a ser pago é de = {Real1}");
        break;
    case >= 3752 and <= 4664:
        valorAliquota2 = salario * al3 / 100;
        Console.WriteLine("Você deve pagar uma aliquota de 22.5%.");
        Console.WriteLine($"Valor a ser pago é de = {Real2}");
        break;
    case >= 4665:
        Console.WriteLine("Você esta isento do IR.");
        break;
}