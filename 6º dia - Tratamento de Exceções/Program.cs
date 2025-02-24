using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bem-vindo ao sexto dia de treinamento em C#!");
        Console.WriteLine("Hoje vamos trabalhar com Tratamento de Exceções.");

        // Bloco try-catch para divisão por zero
        try
        {
            int resultado = 10 / 0;
            Console.WriteLine($"Resultado: {resultado}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }

        // Bloco try-catch para FormatException
        try
        {
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine($"Número digitado: {numero}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }

        // Bloco try-catch genérico
        try
        {
            Console.Write("Digite outro número: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine($"Número digitado: {numero}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro genérico: {ex.Message}");
        }

        // Bloco try-catch com finally
        try
        {
            Console.Write("Digite mais um número: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine($"Número digitado: {numero}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Bloco finally executado.");
        }

        Console.WriteLine("Fim do sexto dia de treinamento. Até amanhã!");
    }
}