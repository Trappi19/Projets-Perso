using System;

class JustePrix
{
    static void PlusOuMoins()
    {
        Random rand = new Random();
        int justePrix = rand.Next(1, 101);
        bool continuer = true;
        while (continuer == true)
        {
            Console.WriteLine("Entrez un nombre pour tenter de le deviner (1 - 100) : ");
            string? input = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"Vous avez entré : {input}");
            Console.WriteLine(justePrix);
            if (int.TryParse(input, out int userGuess))
            {
                if (userGuess < justePrix)
                {
                    Console.WriteLine("C'est plus !");
                }
                else if (userGuess > justePrix)
                {
                    Console.WriteLine("C'est moins !");
                }
                else
                {
                    Console.WriteLine("Félicitations ! Vous avez deviné le juste prix !");
                    continuer = false;
                }
            }
            else
            {
                Console.WriteLine("Entrée invalide. Veuillez entrer un nombre entre 1 et 100.");
            }
        }
    }
}
