using System;

// Classe abstraite Animal
abstract class Animal
{
    public string Name { get; set; }
    public abstract void Move();
    public void Eat()
    {
        Console.WriteLine($"{Name} is eating.");
    }
}

// Classe abstraite pour les animaux bipèdes
abstract class Biped : Animal
{
    public int NumLegs { get; } = 2;
}

// Classe abstraite pour les animaux quadrupèdes
abstract class Quadruped : Animal
{
    public int NumLegs { get; } = 4;
}

// Classes concrètes pour chaque espèce d'animal

class Human : Biped
{
    public override void Move()
    {
        Console.WriteLine($"{Name} is walking on two legs.");
    }
}

class Monkey : Biped
{
    public override void Move()
    {
        Console.WriteLine($"{Name} is swinging from tree to tree.");
    }
}

class Elephant : Quadruped
{
    public override void Move()
    {
        Console.WriteLine($"{Name} is walking on four legs.");
    }
}

class Tortoise : Quadruped
{
    public override void Move()
    {
        Console.WriteLine($"{Name} is moving slowly on four legs.");
    }
}

class Lizard : Quadruped
{
    public override void Move()
    {
        Console.WriteLine($"{Name} is crawling on four legs.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Exemple d'utilisation

        Human human = new Human { Name = "John" };
        human.Move();
        human.Eat();

        Monkey monkey = new Monkey { Name = "George" };
        monkey.Move();
        monkey.Eat();

        Elephant elephant = new Elephant { Name = "Dumbo" };
        elephant.Move();
        elephant.Eat();

        Tortoise tortoise = new Tortoise { Name = "Tom" };
        tortoise.Move();
        tortoise.Eat();

        Lizard lizard = new Lizard { Name = "Larry" };
        lizard.Move();
        lizard.Eat();
    }
}
