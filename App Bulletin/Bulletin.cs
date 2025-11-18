using System;

//C:\\Users\\sevan\\Documents\\Mes Documents\\Cesi\\C#\\Projet-Perso\\Txt

namespace Bulletin
{
    public partial class Start
    {
        public static void Run()
        {
            Console.WriteLine("========================== Bulletin Scolaire ================================");
            Console.WriteLine("=== Bonjour et bienvenue dans le logiciel de création de bulletin scolaire===");
            Console.WriteLine("\n   Que souhaitez-vous faire ?");
            Console.WriteLine("   1. Créer un nouveau bulletin scolaire.");
            Console.WriteLine("   2. Modifier des notes");
            Console.WriteLine("   3. Pressr 'Q' pour quitter le programme.");
            //var key = Console.ReadKey(true);
            //if (quit == true)
            //{
            //    Environment.Exit(0);
            //}
            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    ManageBulletin.CreateBulletin();
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("Modification des notes...");
                    break;
                case "Q":
                case "q":
                case "3":
                    Environment.Exit(0);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Rentrez un choix parmis la liste.");
                    Start.Run();
                    break;
            }
        }
    }
}

public class ManageBulletin
{
    public static void CreateBulletin()
    {
        Console.WriteLine("Création d'un nouveau bulletin scolaire...");
        Dictionary<string, List<double>> Bulletin = new Dictionary<string, List<double>>();
    }
}