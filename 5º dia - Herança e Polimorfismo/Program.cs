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

class Gato : Animal
{
    public override void EmitirSom()
    {
        Console.WriteLine("Miau!");
    }
}

Gato gato = new Gato
{
    Nome = "Mimi"
};
gato.EmitirSom();

List<Animal> animais = new List<Animal>
{
    new Animal { Nome = "Animal Genérico" },
    new Cachorro { Nome = "Rex" },
    new Gato { Nome = "Mimi" }
};

foreach (Animal animal in animais)
{
    animal.EmitirSom();
}