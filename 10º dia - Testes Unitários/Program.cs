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
    }

    // Função simples para testes
    public static int Somar(int a, int b)
    {
        return a + b;
    }
}