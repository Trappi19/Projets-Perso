using System;

class Inversed
{
    static void PhraseInversed()
    {
        Console.WriteLine("Entre une chaîne :");
        string input = Console.ReadLine();

        // Affichage caractère par caractère
        Console.WriteLine("Caractères un par un :");
        foreach (char c in input)
        {
            Console.WriteLine(c);
        }
        // Inversion de la chaîne
        char[] chars = input.ToCharArray();
        Array.Reverse(chars);
        string inversed = new string(chars);

        Console.WriteLine("Chaîne inversée : " + inversed);

        foreach (char c in inversed)
        {
            Console.WriteLine(c);
        }
    }
}