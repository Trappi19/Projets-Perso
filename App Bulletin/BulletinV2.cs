using System;
using System.Collections.Generic;
using System.Linq;

namespace BulletinV2
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



    public class ManageBulletin
    {
        public static void CreateBulletin()
        {
            Dictionary<string, List<double>> Bulletin = new Dictionary<string, List<double>>();
            Dictionary<string, double> Moyennes = new Dictionary<string, double>();

            // 1. Saisie des matières et notes
            while (true)
            {
                Console.WriteLine("Entrez le nom de la matière (ou 'fin' pour terminer) :");
                string subject = Console.ReadLine();
                if (subject.ToLower() == "fin")
                    break;

                Console.WriteLine($"Entrez les notes pour {subject} (séparées par des espaces) :");
                string[] gradesInput = Console.ReadLine().Split(' ');
                List<double> grades = new List<double>();
                foreach (var gradeStr in gradesInput)
                {
                    if (double.TryParse(gradeStr, out double grade))
                    {
                        grades.Add(grade);
                    }
                    else
                    {
                        Console.WriteLine($"Note invalide : {gradeStr}. Elle sera ignorée.");
                    }
                }
                Bulletin[subject] = grades;
            }

            // 2. Calculs des moyennes
            foreach (var matiere in Bulletin)
            {
                if (matiere.Value.Count > 0)
                {
                    double moyenne = matiere.Value.Average();
                    Moyennes[matiere.Key] = moyenne;
                }
                else
                {
                    Moyennes[matiere.Key] = 0;
                }
            }
            Console.Clear();


            // 3. Affichage du bulletin complet à la fin
            Console.WriteLine("\n=========== Bulletin Final ===========");
            foreach (var matiere in Bulletin)
            {
                Console.WriteLine($"\nMatière : {matiere.Key}");
                Console.WriteLine($"  Notes : {string.Join(", ", matiere.Value)}");
                Console.WriteLine($"  Moyenne : {(Moyennes.ContainsKey(matiere.Key) ? Moyennes[matiere.Key].ToString("0.00") : "Pas de note")}");
            }

            Console.WriteLine("\n============== Mention ==============");
            // Calcul de la moyenne générale
            if (Moyennes.Count > 0)
            {
                double moyenneGenerale = Moyennes.Values.Average();
                Console.WriteLine($"\nMoyenne générale : {moyenneGenerale:0.00}");
            }

            Console.WriteLine("\nAs tu besoin de Creer un autre bulletin ?");
            Console.ReadKey();
        }
    }
}