 using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bem-vindo ao segundo dia de treinamento em C#!");
    }
}

static void MensagemPersonalizada(string nome)
{
    Console.WriteLine($"Olá, {nome}! Bem-vindo ao treinamento.");
}

MensagemPersonalizada("Luis");


for (int i = 1; i <= 5; i++)
{
    Console.WriteLine($"Iteração número {i}");
}

int numero = 10;
if (numero > 5)
{
    Console.WriteLine("O número é maior que 5!");
}

Console.WriteLine("Fim do segundo dia de treinamento. Até amanhã!");