using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bem-vindo ao décimo dia de treinamento em C#!");
        Console.WriteLine("Hoje vamos trabalhar com Testes Unitários.");

        // Exemplo de função para testar
        int resultado = Somar(5, 3);
        Console.WriteLine($"Resultado da soma: {resultado}");

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
    }

    // Função simples para testes
    public static int Somar(int a, int b)
    {
        return a + b;
    }

    // Exemplo de função para testar multiplicação
int resultadoMultiplicacao = Multiplicar(5, 3);
Console.WriteLine($"Resultado da multiplicação: {resultadoMultiplicacao}");

// Função simples para testes
public static int Multiplicar(int a, int b)
{
    return a * b;
}
}