 using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bem-vindo ao terceiro dia de treinamento em C#!");
    }
}

Console.WriteLine("Este é o primeiro commit de alteração do terceiro dia.");

static int Soma(int a, int b)
{
    return a + b;
}

int resultado = Soma(5, 3);
Console.WriteLine($"O resultado da soma é: {resultado}");

int[] numeros = { 1, 2, 3, 4, 5 };
foreach (int numero in numeros)
{
    Console.WriteLine($"Número: {numero}");
}