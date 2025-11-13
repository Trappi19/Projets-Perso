using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Entrez une chaîne de caractères :");
        string input = Console.ReadLine();

        foreach (char c in input)
        {
            if (char.IsDigit(c))
            {
                Console.WriteLine($"{c} est un chiffre.");
            }
            else if (char.IsLetter(c))
            {
                Console.WriteLine($"{c} est une lettre.");
            }
            else
            {
                Console.WriteLine($"{c} est un caractère spécial.");
            }
        }
    }
}