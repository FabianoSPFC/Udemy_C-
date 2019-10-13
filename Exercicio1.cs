//Feito por Fabiano Filho﻿

using System;
using System.Globalization;
namespace EstruturaSequencial
{
	class Exercicio1
	{
		/*Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma
		mensagem explicativa, conforme exemplos.*/

		static void Main(string[] args)
		{
			Console.Write("Digite um valor: ");
			int valor1 = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
			Console.Write("Digite outro valor: ");
			int valor2 = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

			int resultado = valor1 + valor2;
			Console.WriteLine($"Soma: {resultado:F2}");
		}
	}
}
