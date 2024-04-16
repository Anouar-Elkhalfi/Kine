// les classes
using System;

class Character
{
    public string Name { get; set; }
    public int HealthPoints { get; set; }
    public int AttackStrength { get; set; }
    public int DefenseStrength { get; set; }

    public Character(string name, int healthPoints, int attackStrength, int defenseStrength)
    {
        Name = name;
        HealthPoints = healthPoints;
        AttackStrength = attackStrength;
        DefenseStrength = defenseStrength;
    }

    public bool IsAlive()
    {
        return HealthPoints > 0;
    }

    public void Attack(Character target)
    {
        if (!IsAlive())
        {
            Console.WriteLine($"{Name} est déjà mort et ne peut pas attaquer.");
            return;
        }

        if (!target.IsAlive())
        {
            Console.WriteLine($"{target.Name} est déjà mort et ne peut pas être attaqué.");
            return;
        }

        int damage = Math.Max(AttackStrength - target.DefenseStrength, 0);
        target.HealthPoints -= damage;

        Console.WriteLine($"{Name} attaque {target.Name} et lui inflige {damage} points de dégâts.");

        if (!target.IsAlive())
        {
            Console.WriteLine($"{target.Name} est mort !");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Character player1 = new Character("Joueur 1", 100, 20, 10);
        Character player2 = new Character("Joueur 2", 100, 15, 15);

        Console.WriteLine("Début du combat !");

        while (player1.IsAlive() && player2.IsAlive())
        {
            player1.Attack(player2);
            if (!player2.IsAlive()) break; // Vérifie si le joueur 2 est encore en vie après chaque attaque de joueur 1
            player2.Attack(player1);
        }

        if (player1.IsAlive())
        {
            Console.WriteLine($"{player1.Name} a gagné !");
        }
        else
        {
            Console.WriteLine($"{player2.Name} a gagné !");
        }
    }
}
// fin de classe 
// debut d'encapsulation 
using System;

class Character
{
    public string Name { get; set; }
    public int HealthPoints { get; set; }
    public int AttackStrength { get; set; }
    public int DefenseStrength { get; set; }

    public Character(string name, int healthPoints, int attackStrength, int defenseStrength)
    {
        Name = name;
        HealthPoints = healthPoints;
        AttackStrength = attackStrength;
        DefenseStrength = defenseStrength;
    }

    public bool IsAlive()
    {
        return HealthPoints > 0;
    }

    public void Attack(Character target)
    {
        if (!IsAlive())
        {
            Console.WriteLine($"{Name} est déjà mort et ne peut pas attaquer.");
            return;
        }

        if (!target.IsAlive())
        {
            Console.WriteLine($"{target.Name} est déjà mort et ne peut pas être attaqué.");
            return;
        }

        int damage = Math.Max(AttackStrength - target.DefenseStrength, 0);
        target.HealthPoints -= damage;

        Console.WriteLine($"{Name} attaque {target.Name} et lui inflige {damage} points de dégâts.");

        if (!target.IsAlive())
        {
            Console.WriteLine($"{target.Name} est mort !");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Character player1 = new Character("Joueur 1", 100, 20, 10);
        Character player2 = new Character("Joueur 2", 100, 15, 15);

        Console.WriteLine("Début du combat !");

        while (player1.IsAlive() && player2.IsAlive())
        {
            player1.Attack(player2);
            if (!player2.IsAlive()) break; // Vérifie si le joueur 2 est encore en vie après chaque attaque de joueur 1
            player2.Attack(player1);
        }

        if (player1.IsAlive())
        {
            Console.WriteLine($"{player1.Name} a gagné !");
        }
        else
        {
            Console.WriteLine($"{player2.Name} a gagné !");
        }
    }
}
// fin d'encapsulation
// début de POO Constructeurs 
using System;

class Building
{
    private int floorCount;
    private double size;

    public Building(int floorCount, double size)
    {
        this.floorCount = floorCount;
        this.size = size;
    }

    public Building(int floorCount)
    {
        this.floorCount = floorCount;
        this.size = floorCount * 3; // La hauteur idéale d'un étage est de 3m
    }

    public double GetFloorMaxSize()
    {
        return size / floorCount;
    }

    public int GetFloorCount()
    {
        return floorCount;
    }

    public double GetSize()
    {
        return size;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bienvenue dans le programme de calcul de bâtiment !");
        Console.WriteLine("Veuillez entrer le nombre d'étages du bâtiment :");
        int floorCount = Convert.ToInt32(Console.ReadLine());

        Building building = new Building(floorCount);

        Console.WriteLine($"Le bâtiment possède {building.GetFloorCount()} étages.");
        Console.WriteLine($"La taille maximale d'un étage est de {building.GetFloorMaxSize()} mètres.");
        Console.WriteLine($"La taille totale du bâtiment est de {building.GetSize()} mètres.");
    }
}


