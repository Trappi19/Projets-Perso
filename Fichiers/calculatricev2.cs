using System;

public class CalculatriceV2
{
    public static void Main2()
    {
        Console.WriteLine("=== Calculatrice Avancée ===");
        Console.WriteLine("Choisissez une opération (1: Addition, 2: Soustraction, 3: Multiplication, 4: Division) : ");
        string? choix = Console.ReadLine();

        switch (choix)
        {
            case "1":
                Additionner();
                break;
            case "2":
                Soustraire();
                break;
            case "3":
                Multiplier();
                break;
            case "4":
                Diviser();
                break;
            default:
                Console.WriteLine("Opération invalide.");
                break;
        }
    }

    public static void Additionner()
    {
        Console.Write("Entrez le premier nombre : ");
        double nombre1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Entrez le deuxième nombre : ");
        double nombre2 = Convert.ToDouble(Console.ReadLine());

        double resultat = nombre1 + nombre2;
        Console.WriteLine($"Le résultat de l'addition est : {resultat}");
    }
    public static void Soustraire()
    {
        Console.Write("Entrez le premier nombre : ");
        double nombre1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Entrez le deuxième nombre : ");
        double nombre2 = Convert.ToDouble(Console.ReadLine());

        double resultat = nombre1 - nombre2;
        Console.WriteLine($"Le résultat de la soustraction est : {resultat}");
    }
    public static void Multiplier()
    {
        Console.Write("Entrez le premier nombre : ");
        double nombre1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Entrez le deuxième nombre : ");
        double nombre2 = Convert.ToDouble(Console.ReadLine());

        double resultat = nombre1 * nombre2;
        Console.WriteLine($"Le résultat de la multiplication est : {resultat}");
    }
    public static void Diviser()
    {
        Console.Write("Entrez le premier nombre : ");
        double nombre1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Entrez le deuxième nombre : ");
        double nombre2 = Convert.ToDouble(Console.ReadLine());

        if (nombre2 != 0)
        {
            double resultat = nombre1 / nombre2;
            Console.WriteLine($"Le résultat de la division est : {resultat}");
        }
        else
        {
            Console.WriteLine("Erreur : Division par zéro n'est pas permise.");
        }
    }

}