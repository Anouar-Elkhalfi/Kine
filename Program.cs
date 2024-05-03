using System;
using Models;
using System.Collections.Generic;

class Program
{
    static List<Eleve> eleves = new List<Eleve>();

    static void Main()
    {
        int choix;
        do
        {
            choix = AfficherMenuPrincipal();
            switch (choix)
            {
                case 1:
                    GererMenuEleves();
                    break;
                case 2:
                    GererMenuCours();
                    break;
                case 3:
                    Console.WriteLine("Merci d'avoir utilisé l'application.");
                    return;
                default:
                    Console.WriteLine("Option invalide, veuillez réessayer.");
                    break;
            }
        } while (choix != 3);
    }

    static int AfficherMenuPrincipal()
    {
        Console.WriteLine("\nMenu Principal:");
        Console.WriteLine("1. Élèves");
        Console.WriteLine("2. Cours");
        Console.WriteLine("3. Quitter");
        Console.Write("Entrez votre choix: ");
        if (int.TryParse(Console.ReadLine(), out int choix))
            return choix;
        return -1;
    }

    static void GererMenuEleves()
    {
        int choix;
        do
        {
            Console.WriteLine("\nMenu Élèves:");
            Console.WriteLine("1. Lister les élèves");
            Console.WriteLine("2. Créer un nouvel élève");
            Console.WriteLine("3. Consulter un élève existant");
            Console.WriteLine("4. Ajouter une note et une appréciation");
            Console.WriteLine("5. Revenir au menu principal");
            Console.Write("Entrez votre choix: ");
            if (!int.TryParse(Console.ReadLine(), out choix))
                choix = -1;

            switch (choix)
            {
                case 1:
                    ListerEleves();
                    break;
                case 2:
                    CreerEleve();
                    break;
                case 3:
                    ConsulterEleve();
                    break;
                case 4:
                    AjouterNote();
                    break;
                case 5:
                    break;
                default:
                    Console.WriteLine("Option invalide, veuillez réessayer.");
                    break;
            }
        } while (choix != 5);
    }

    static void ListerEleves()
    {
        if (eleves.Count == 0)
        {
            Console.WriteLine("Aucun élève enregistré.");
        }
        else
        {
            foreach (Eleve eleve in eleves)
            {
                Console.WriteLine($"Élève: {eleve.Prenom} {eleve.Nom}");
            }
        }
    }

    static void CreerEleve()
    {
        Console.Write("Entrez le prénom de l'élève: ");
        string prenom = Console.ReadLine();
        Console.Write("Entrez le nom de l'élève: ");
        string nom = Console.ReadLine();

        Eleve nouvelEleve = new Eleve { Prenom = prenom, Nom = nom };
        eleves.Add(nouvelEleve);
        Console.WriteLine("Nouvel élève créé.");
    }

    static void ConsulterEleve()
    {
        Console.Write("Entrez le nom de l'élève à consulter: ");
        string nom = Console.ReadLine();
        var eleve = eleves.Find(e => e.Nom.ToLower() == nom.ToLower());
        if (eleve != null)
        {
            Console.WriteLine($"Élève: {eleve.Prenom} {eleve.Nom}");
            foreach (var note in eleve.Notes)
            {
                Console.WriteLine($"Cours: {note.Cours}, Note: {note.Valeur}, Appréciation: {note.Appreciation}");
            }
        }
        else
        {
            Console.WriteLine("Élève non trouvé.");
        }
    }

    static void AjouterNote()
    {
        Console.Write("Entrez le nom de l'élève à qui ajouter une note: ");
        string nom = Console.ReadLine();
        var eleve = eleves.Find(e => e.Nom.ToLower() == nom.ToLower());
        if (eleve != null)
        {
            Console.Write("Entrez le nom du cours: ");
            string cours = Console.ReadLine();
            Console.Write("Entrez la note: ");
            double valeur = double.Parse(Console.ReadLine());
            Console.Write("Entrez l'appréciation: ");
            string appreciation = Console.ReadLine();

            Note note = new Note { Cours = cours, Valeur = valeur, Appreciation = appreciation };
            eleve.Notes.Add(note);
            Console.WriteLine("Note ajoutée.");
        }
        else
        {
            Console.WriteLine("Élève non trouvé.");
        }
    }

    static void GererMenuCours()
    {
        Console.WriteLine("Gestion des cours non implémentée.");
    }
}
