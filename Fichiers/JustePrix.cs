using System;
using log;

public class JustePrix
{

    private static log.Log log = new log.Log(); //instauration log
    public static void PlusOuMoins()
    {
        log.CleanLog(); //nettoyage log

        Random rand = new Random();
        int justePrix = rand.Next(1, 101);
        bool continuer = true;
        log.WriteLog($"Le juste prix a été généré. Nombre sélectionné {justePrix}"); //log du nombre généré
        while (continuer == true)
        {
            Console.WriteLine("Entrez un nombre pour tenter de le deviner (1 - 100) : ");
            string? input = Console.ReadLine();

            log.WriteLog($"L'utilisateur a entré : {input}"); //log de l'entrée utilisateur

            Console.Clear();
            Console.WriteLine($"Vous avez entré : {input}");
            Console.WriteLine(justePrix);
            if (int.TryParse(input, out int userGuess))
            {
                if (userGuess < justePrix)
                {
                    Console.WriteLine("C'est plus !");
                    log.WriteLog($"L'utilisateur a entré {userGuess}, qui est plus petit que le juste prix {justePrix}."); //log de la comparaison
                }
                else if (userGuess > justePrix)
                {
                    Console.WriteLine("C'est moins !");
                    log.WriteLog($"L'utilisateur a entré {userGuess}, qui est plus grand que le juste prix {justePrix}."); //log de la comparaison
                }
                else
                {
                    Console.WriteLine("Félicitations ! Vous avez deviné le juste prix !");
                    continuer = false;
                    log.WriteLog($"L'utilisateur a entré {userGuess}, et a deviné le juste prix."); //log de la victoire
                }
            }
            else
            {
                Console.WriteLine("Entrée invalide. Veuillez entrer un nombre entre 1 et 100.");
                log.WriteLog("Erreur : L'utilisateur a entré une valeur invalide.\n Entré : {userGuess}"); //log de l'erreur
            }
        }
    }
}
