using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bem-vindo ao quarto dia de treinamento em C#!");
        Console.WriteLine("Hoje irei trabalhar com Classes e Objetos.");

        // Criando um objeto da classe Pessoa
        Pessoa pessoa1 = new Pessoa
        {
            Nome = "Luis",
            Idade = 20
        };
        pessoa1.Apresentar();

        // Criando um objeto da classe Calculadora
        Calculadora calc = new Calculadora();
        Console.WriteLine($"Soma: {calc.Somar(5, 3)}");
        Console.WriteLine($"Multiplicação: {calc.Multiplicar(5, 3)}");

        // Criando um objeto da classe Aluno
        Aluno aluno1 = new Aluno
        {
            Nome = "Maria",
            Idade = 20,
            Matricula = "12345"
        };
        aluno1.Apresentar();
        aluno1.Estudar();

        Console.WriteLine("Fim do quarto dia de treinamento.");
    }
}

// Classe Pessoa
class Pessoa
{
    private string _nome;
    private int _idade;

    public string Nome
    {
        get { return _nome; }
        set { _nome = value; }
    }

    public int Idade
    {
        get { return _idade; }
        set { _idade = value; }
    }

    public void Apresentar()
    {
        Console.WriteLine($"Olá, meu nome é {_nome} e tenho {_idade} anos.");
    }
}

// Classe Calculadora
class Calculadora
{
    public int Somar(int a, int b)
    {
        return a + b;
    }

    public int Multiplicar(int a, int b)
    {
        return a * b;
    }
}

// Classe Aluno (herda de Pessoa)
class Aluno : Pessoa
{
    public string Matricula { get; set; }

    public void Estudar()
    {
        Console.WriteLine($"{Nome} está estudando.");
    }
}