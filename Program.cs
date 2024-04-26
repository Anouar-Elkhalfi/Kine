using System;
using System.Collections.Generic;

class Program
{
    static DataManager dataManager;
    static List<Eleve> eleves;

    static void Main(string[] args)
    {
        string filePath = args.Length > 0 ? args[0] : "data.json";
        dataManager = new DataManager(filePath);
        eleves = dataManager.LoadData();

        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("Menu Principal:\n1. Gérer Élèves\n2. Gérer Cours\n3. Quitter");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    ManageStudents();
                    break;
                case "2":
                    ManageCourses();
                    break;
                case "3":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Option invalide.");
                    break;
            }
        }
    }

    static void ManageStudents()
    {
        // Logique pour gérer les élèves
    }

    static void ManageCourses()
    {
        // Logique pour gérer les cours
    }
}
