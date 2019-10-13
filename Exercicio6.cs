using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace Secao3
{
	/*Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e
	mostre:
	a) a área do triângulo retângulo que tem A por base e C por altura.
	b) a área do círculo de raio C. (pi = 3.14159)
	c) a área do trapézio que tem A e B por bases e C por altura.
	d) a área do quadrado que tem lado B.
	e) a área do retângulo que tem lados A e B.*/

	class Exercicio6
	{
		static double Pi = 3.14159;

		static void Main(string[] args)
		{
			Console.Write("Digite o 1º Valor: ");
			float Valor1 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
			Console.Write("Digite o 2º Valor: ");
			float Valor2 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
			Console.Write("Digite o 3º Valor: ");
			float Valor3 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

			double resultado1 = AreaTriangulo(Valor1, Valor3);
			double resultado2 = AreaCirculo(Valor3);
			double resultado3 = AreaTrapezio(Valor1, Valor2, Valor3);
			double resultado4 = AreaQuadrado(Valor2);
			double resultado5 = AreaRetangulo(Valor1, Valor2);

			Console.WriteLine($"A área do Triângulo = {resultado1:F2}");
			Console.WriteLine($"A área do Circulo = {resultado2:F2}");
			Console.WriteLine($"A área do Trapézio = {resultado3:F2}");
			Console.WriteLine($"A área do Quadrado = {resultado4:F2}");
			Console.WriteLine($"A área do Retângulo = {resultado5:F2}");
		}

		static double AreaTriangulo(double bases, double altura)
		{
			return (bases * altura) / 2;
		}

		static double AreaCirculo(double raio)
		{
			return Math.Pow(raio,2) * Pi;
		}
		static double AreaTrapezio(double bases1, double bases2, double altura)
		{
			return ((bases1 + bases2) * altura) / 2;
		}

		static double AreaQuadrado(double lado)
		{
			return Math.Pow(lado,2);
		}

		static double AreaRetangulo(double bases, double altura)
		{
			return bases * altura;
		}
	}
}
