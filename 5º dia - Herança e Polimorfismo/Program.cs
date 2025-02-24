 using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bem-vindo ao quinto dia de treinamento em C#!");
        Console.WriteLine("Hoje vamos trabalhar com Herança e Polimorfismo.");

        
    }
}

class Animal
{
    public string Nome { get; set; }

    public virtual void EmitirSom()
    {
        Console.WriteLine("Som genérico de animal.");
    }
}

Animal animal = new Animal
{
    Nome = "Animal Genérico"
};
animal.EmitirSom();

class Cachorro : Animal
{
    public override void EmitirSom()
    {
        Console.WriteLine("Au Au!");
    }
}

Cachorro cachorro = new Cachorro
{
    Nome = "Rex"
};
cachorro.EmitirSom();