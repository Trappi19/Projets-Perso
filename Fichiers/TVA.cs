using System;

public class TVA
{
    public void CalculateTVA()
    {
        string? inputElem;
        
        do
        {
            Console.Clear(); // Nettoie l'écran à chaque tour
            Console.WriteLine("=== Calculateur de TVA ===");
            Console.WriteLine("1 - Taux réduit");
            Console.WriteLine("2 - Taux intermédiaire");
            Console.WriteLine("3 - Services");
            Console.WriteLine("Q - Quitter");
            Console.Write("\nVotre choix : ");
            
            inputElem = Console.ReadLine()?.ToLower()?.Trim();

            switch (inputElem)
            {
                case "1":
                case "taux réduit":
                case "taux reduit":
                    Console.WriteLine("\n✓ La TVA est de 5.5%");
                    break;
                    
                case "2":
                case "taux intermédiaire":
                case "taux intermediaire":
                    Console.WriteLine("\n✓ La TVA est de 10%");
                    break;
                    
                case "3":
                case "services":
                    Console.WriteLine("\n✓ La TVA est de 20%");
                    break;
                    
                case "q":
                    Console.WriteLine("\nÀ bientôt !");
                    break;
                    
                default:
                    Console.WriteLine("\n✗ Choix invalide, réessaye !");
                    break;
            }
            
            if (inputElem != "q")
            {
                Console.WriteLine("\nAppuyez sur une touche pour continuer...");
                Console.ReadKey();
            }
            
        } while (inputElem != "q");
    }
}