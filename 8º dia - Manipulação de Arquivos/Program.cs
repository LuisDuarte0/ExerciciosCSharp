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

        // Verificando se o arquivo existe
if (File.Exists(caminhoArquivo))
{
    Console.WriteLine("O arquivo existe.");
}
else
{
    Console.WriteLine("O arquivo não existe.");
}

// Copiando o arquivo
string caminhoCopia = "copia_arquivo.txt";
File.Copy(caminhoArquivo, caminhoCopia);
Console.WriteLine("Arquivo copiado com sucesso.");

    // Excluindo o arquivo copiado
File.Delete(caminhoCopia);
Console.WriteLine("Arquivo copiado excluído com sucesso.");

// Listando arquivos no diretório atual
var arquivos = Directory.GetFiles(Directory.GetCurrentDirectory());
Console.WriteLine("Arquivos no diretório atual:");
foreach (var arquivo in arquivos)
{
    Console.WriteLine(arquivo);
}
    }
}