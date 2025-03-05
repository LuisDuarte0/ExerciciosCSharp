using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bem-vindo ao oitavo dia de treinamento em C#!");
        Console.WriteLine("Hoje vamos trabalhar com Manipulação de Arquivos.");

        string caminhoArquivo = "arquivo.txt";

        // Escrevendo no arquivo
        File.WriteAllText(caminhoArquivo, "Olá, este é um arquivo de teste!");

        // Lendo o arquivo
        string conteudo = File.ReadAllText(caminhoArquivo);
        Console.WriteLine($"Conteúdo do arquivo: {conteudo}");

        // Adicionando mais texto ao arquivo
        File.AppendAllText(caminhoArquivo, "\nMais uma linha adicionada.");
        Console.WriteLine("Texto adicionado ao arquivo.");
    }
}