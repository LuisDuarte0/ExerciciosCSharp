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