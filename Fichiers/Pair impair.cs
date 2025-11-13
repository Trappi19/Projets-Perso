public class AfficherPairImpair
{
    public static void AfficherEtat(int nombre)
    {
        if (nombre % 2 == 0)
        {
            Console.WriteLine($"{nombre} est un nombre pair.");
        }
        else
        {
            Console.WriteLine($"{nombre} est un nombre impair.");
        }
    }
}