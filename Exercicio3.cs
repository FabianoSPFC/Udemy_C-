//Feito por Fabiano Filho
using System;
using System.Globalization;

namespace Secao3
{
	/*Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto
	de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).*/

	class Exercicio3
	{
		static void Main(string[] args)
		{
			Console.Write("Digite o valor de A: ");
			double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
			Console.Write("Digite o valor de B: ");
			double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
			Console.Write("Digite o valor de C: ");
			double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
			Console.Write("Digite o valor de D: ");
			double d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

			double resultado = Diferenca(a, b, c, d);
			Console.WriteLine($"A diferença deu: {resultado:F1}");
		}

		static double Diferenca(double A, double B, double C, double D)
		{
			return (A * B - C * D);
		}
	}
}
