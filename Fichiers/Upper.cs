using System;

class Bouh
{
    static void Main()
    {
        Console.Write("Donne une chaîne : ");
        string input = Console.ReadLine();
        string output = "";

        foreach (char c in input)
        {
            output += Char.ToUpper(c); // Convertit chaque caractère
        }

        Console.WriteLine("En majuscule : " + output);
    }
}