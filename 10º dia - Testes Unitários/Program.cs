using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    // Função simples para testes
    public static int Somar(int a, int b)
    {
        return a + b;
    }

    // Função simples para testes
    public static int Multiplicar(int a, int b)
    {
        return a * b;
    }

    // Função simples para testes
    public static double Dividir(double a, double b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Divisão por zero não é permitida.");
        }
        return a / b;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Bem-vindo ao décimo dia de treinamento em C#!");
        Console.WriteLine("Hoje vamos trabalhar com Testes Unitários.");

        // Exemplo de função para testar
        int resultado = Somar(5, 3);
        Console.WriteLine($"Resultado da soma: {resultado}");

        // Exemplo de função para testar multiplicação
        int resultadoMultiplicacao = Multiplicar(5, 3);
        Console.WriteLine($"Resultado da multiplicação: {resultadoMultiplicacao}");

        // Criando uma lista de números para exemplos adicionais
        List<int> numeros = new List<int> { 10, 20, 30, 40, 50 };

        // Usando LINQ para ordenar números
        var numerosOrdenados = numeros.OrderBy(n => n).ToList();
        Console.WriteLine("Números ordenados:");
        foreach (var numero in numerosOrdenados)
        {
            Console.WriteLine(numero);
        }

        // Usando LINQ para encontrar o maior número
        int maiorNumero = numeros.Max();
        Console.WriteLine($"Maior número: {maiorNumero}");

        // Exemplo de função para testar divisão
        try
        {
            double resultadoDivisao = Dividir(10, 2);
            Console.WriteLine($"Resultado da divisão: {resultadoDivisao}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
    }
}