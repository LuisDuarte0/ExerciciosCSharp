 using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bem-vindo ao quarto dia de treinamento em C#!");
        Console.WriteLine("Hoje irei trabalhar com Classes e Objetos.");
    }
}


class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public void Apresentar()
    {
        Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos.");
    }
}

Pessoa pessoa1 = new Pessoa
{
    Nome = "Luis",
    Idade = 20
};
pessoa1.Apresentar();