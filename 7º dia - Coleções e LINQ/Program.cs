using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bem-vindo ao sétimo dia de treinamento em C#!");
        Console.WriteLine("Hoje vamos trabalhar com Coleções e LINQ.");

        // Criando uma lista de números
        List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Usando LINQ para filtrar números pares
        var numerosPares = numeros.Where(n => n % 2 == 0).ToList();

        Console.WriteLine("Números pares:");
        foreach (var numero in numerosPares)
        {
            Console.WriteLine(numero);
        }

        // Usando LINQ para calcular a soma dos números
        int soma = numeros.Sum();
        Console.WriteLine($"Soma dos números: {soma}");
    }
}