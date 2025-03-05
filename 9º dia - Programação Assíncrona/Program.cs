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

        Console.WriteLine("Iniciando segunda tarefa assíncrona...");
await Task.Run(() => 
{
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine($"Tarefa assíncrona em execução: {i + 1}");
        Task.Delay(500).Wait();
    }
});
Console.WriteLine("Segunda tarefa assíncrona concluída!");

Console.WriteLine("Iniciando terceira tarefa assíncrona...");
await Task.Run(() => 
{
    for (int i = 0; i < 3; i++)
    {
        Console.WriteLine($"Tarefa assíncrona 3 em execução: {i + 1}");
        Task.Delay(1000).Wait();
    }
});
Console.WriteLine("Terceira tarefa assíncrona concluída!");

    }
}