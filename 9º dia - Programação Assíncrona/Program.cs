using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Bem-vindo ao nono dia de treinamento em C#!");
        Console.WriteLine("Hoje vamos trabalhar com Programação Assíncrona.");

        Console.WriteLine("Iniciando tarefa assíncrona...");
        await Task.Delay(2000); // Simula uma tarefa demorada
        Console.WriteLine("Tarefa assíncrona concluída!");

        Console.WriteLine("Fim do nono dia de treinamento.");
    }
}