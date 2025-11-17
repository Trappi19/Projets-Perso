//######################################################################
//######################################################################
//##########  Programme de gestion de scores d'équipe  #################
//######################################################################
//######################################################################


using System;
using log;

namespace ScoreTeam
{
    public class Start
    {
        public static void Run()
        {
            bool restart = (false);
            Console.WriteLine("=== Gestion des Scores d'Équipe ===");
            //Console.Write("Donne moi le path de ton fichier :");
            //Console.WriteLine("Donne moi le path de ton fichier scores"); //C:\\Users\\sevan\\Documents\\Mes Documents\\Cesi\\C#\\Projet-Perso\\Txt\\score.txt
            //string? path = Console.ReadLine();
            string? path = "C:\\Users\\sevan\\Documents\\Mes Documents\\Cesi\\C#\\Projet-Perso\\Txt\\score.txt";
            Console.WriteLine("Que veux tu faire ?");
            Console.WriteLine("1. Afficher le classement des scores.");
            Console.WriteLine("2. Afficher le podium.");
            Console.WriteLine("3. Modifier une valeur.");
            Console.WriteLine("4. Rajouter une valeur.");
            Console.WriteLine("4. Supprimer une score.");

            switch (Console.ReadLine())
            {
                case "1":
                    Score.AfficherScore(path);
                    break;
                case "2":
                    Score.Classement(path);
                    break;
                case "3":
                    Score.Modify(path);
                    break;
                case "4":
                    new Score().Ajouter(path);
                    break;
                case "5":
                    Score.Delete(path);
                    break; 
                default:
                    Console.WriteLine("Option invalide. Veuillez choisir 1, 2 ou 3.");
                    break;
            }
        }
    }







    public class Score
    {
        public static void AfficherScore(string path)
        {
            var scores = new Dictionary<string, double>();
            string[] lignes = File.ReadAllLines(path);
            foreach (string ligne in lignes)
            {
                // Séparer la ligne avec ":"
                string[] parts = ligne.Split(':');

                // La clé est le premier élément (string)
                string nom = parts[0];

                // La valeur est le deuxième élément converti en double
                double valeur = double.Parse(parts[1]);

                // Ajouter au dictionnaire
                scores.Add(nom, valeur);
            }
            foreach (var item in scores)
            {
                Console.WriteLine($"{item.Key}:{item.Value}"); // Afficher dictionnaire
            }
            Console.WriteLine("\nAs tu Autre chose à faire ? (O/N)");
            string input = Console.ReadLine();

            if (input!.ToUpper() == "O")
            {
                Console.Clear();
                Start.Run();
            }
        }







        public static void Classement(string path)
        {
            Score score = new Score();
            var scores = new Dictionary<string, double>();
            string[] lignes = File.ReadAllLines(path);
            foreach (string ligne in lignes)
            {
                // Séparer la ligne avec ":"
                string[] parts = ligne.Split(':');

                // La clé est le premier élément (string)
                string nom = parts[0];

                // La valeur est le deuxième élément converti en double
                double valeur = double.Parse(parts[1]);

                // Ajouter au dictionnaire
                scores.Add(nom, valeur);
            }

            var scoresTrie = scores.OrderByDescending(x => x.Value);

            Console.WriteLine("\nClassement complet:");
            int position = 1;
            foreach (var item in scoresTrie)
            {
                Console.WriteLine($"{position}. {item.Key} : {item.Value}");
                position++;
            }

            // Puis le podium
            var top3 = scoresTrie.Take(3).ToList();
            Console.WriteLine("\n PODIUM ");
            Console.WriteLine($" {top3[0].Key} : {top3[0].Value}");
            Console.WriteLine($" {top3[1].Key} : {top3[1].Value}");
            Console.WriteLine($" {top3[2].Key} : {top3[2].Value}");
            Console.WriteLine("\nAs tu Autre chose à faire ? (O/N)");
            string input = Console.ReadLine();

            if (input!.ToUpper() == "O")
            {
                Console.Clear();
                Start.Run();
            }
        }







        public static void Modify(string path)
        {
            Score score = new Score();
            var scores = new Dictionary<string, double>();
            string[] lignes = File.ReadAllLines(path);
            foreach (string ligne in lignes)
            {
                // Séparer la ligne avec ":"
                string[] parts = ligne.Split(':');

                // La clé est le premier élément (string)
                string nom = parts[0];

                // La valeur est le deuxième élément converti en double
                double valeur = double.Parse(parts[1]);

                // Ajouter au dictionnaire
                scores.Add(nom, valeur);
            }


            Console.WriteLine("As tu besoin de voir les scores ? (O/N)");
            string? input = Console.ReadLine();
            if (input!.ToUpper() == "O")
            {
                AfficherScore(path);
            }


            Console.Write("Donne le nom du joueur à modifier :");
            string? nomToModify = Console.ReadLine();
            Console.Write("Donne le nouveau score :");
            double newScore = double.Parse(Console.ReadLine());
            if (scores.ContainsKey(nomToModify))
            {
                Console.WriteLine($"Score actuel de {nomToModify} : {scores[nomToModify]}");
                Console.WriteLine("Nouveau score ?");

                if (int.TryParse(Console.ReadLine(), out int nouveauScore))
                {
                    scores[nomToModify] = nouveauScore;
                    Console.WriteLine($"Score de {nomToModify} modifié à {nouveauScore} !");
                }
                else
                {
                    Console.WriteLine("Valeur invalide !");
                }
            }
            else
            {
                Console.WriteLine("Cette clé n'existe pas !");
            }
        }






        public static void Delete(string path)
        {
            // En dev
        }   







        public void Ajouter(string path)
        { // En dev
            Console.Write("Donnez le pseudo du joueurs :");
            string? nom = Console.ReadLine();
            Console.Write("Donnez le score du joueurs :");
            double valeur = double.Parse(Console.ReadLine());

            // Ecriture dans le txt
            StreamWriter sw = new StreamWriter(path, append: true);
            sw.WriteLine($"{nom}:{valeur}");
            Console.WriteLine("Score ajouté.");
            //Console.WriteLine("Besoin d'ajouter une autre valeur ?");
            sw.Close();

            Console.WriteLine("As tu Autre chose à faire ? (O/N)");
            string input = Console.ReadLine();

            if (input!.ToUpper() == "O")
            {
                Console.Clear();
                Start.Run();
            }
        }
    }
}
