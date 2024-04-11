// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//ceci est un commentaire 
Console.WriteLine("j'apprends le c#");
// le Write et Write Line différence 
Console.Write("exemple ");
// declaration de variable: Type nom = valeur;
// les types :int,string , bool /// nom : estVivan
int age = 23;
string prenom = "anouar";
bool estVivan = true;
// typage implicite 
var lastName = "el khalfi";
var taille = 128;
var faux = false;
// reaffecter une variable
taille = 200;

using System;

class Program
{
    static void Main(string[] args)
    {
        // Récupération du premier nombre saisi par l'utilisateur
        Console.WriteLine("Entrez le premier nombre:");
        string input1 = Console.ReadLine();
        int number1;
        while (!int.TryParse(input1, out number1))
        {
            Console.WriteLine("Veuillez entrer un nombre valide:");
            input1 = Console.ReadLine();
        }

        // Récupération du deuxième nombre saisi par l'utilisateur
        Console.WriteLine("Entrez le deuxième nombre:");
        string input2 = Console.ReadLine();
        int number2;
        while (!int.TryParse(input2, out number2))
        {
            Console.WriteLine("Veuillez entrer un nombre valide:");
            input2 = Console.ReadLine();
        }

        // Demande du message de succès
        Console.WriteLine("Entrez un message de succès:");
        string successMessage = Console.ReadLine();

        // Addition des deux nombres
        int result = number1 + number2;

        // Affichage de l'opération et du résultat
        Console.WriteLine($"{number1} + {number2} = {result}");

        // Affichage du message de succès
        Console.WriteLine(successMessage);
    }
}
