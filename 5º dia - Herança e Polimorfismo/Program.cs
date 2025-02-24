using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bem-vindo ao quinto dia de treinamento em C#!");
        Console.WriteLine("Hoje vamos trabalhar com Herança e Polimorfismo.");

        // Criando um animal genérico
        Animal animal = new Animal
        {
            Nome = "Animal Genérico"
        };
        animal.EmitirSom();

        // Criando um cachorro
        Cachorro cachorro = new Cachorro
        {
            Nome = "Rex"
        };
        cachorro.EmitirSom();

        // Criando um gato
        Gato gato = new Gato
        {
            Nome = "Mimi"
        };
        gato.EmitirSom();

        // Demonstrando polimorfismo com uma lista de animais
        List<Animal> animais = new List<Animal>
        {
            new Animal { Nome = "Animal Genérico" },
            new Cachorro { Nome = "Rex" },
            new Gato { Nome = "Mimi" }
        };

        foreach (Animal a in animais)
        {
            a.EmitirSom();
        }

        Console.WriteLine("Fim do quinto dia de treinamento. Até amanhã!");
    }
}

// Classe base Animal
class Animal
{
    public string Nome { get; set; }

    public virtual void EmitirSom()
    {
        Console.WriteLine("Som genérico de animal.");
    }
}

// Classe derivada Cachorro
class Cachorro : Animal
{
    public override void EmitirSom()
    {
        Console.WriteLine("Au Au!");
    }
}

// Classe derivada Gato
class Gato : Animal
{
    public override void EmitirSom()
    {
        Console.WriteLine("Miau!");
    }
}