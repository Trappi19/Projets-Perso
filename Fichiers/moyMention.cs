using System;
using System.Collections.Generic;
using System.Linq;

class MoyenneMention
{
    static void Main()
    {
        List<(string matiere, double note)> matieres = new List<(string, double)>();
        
        Console.WriteLine("Entrez le nombre de matières:");
        int nombre = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < nombre; i++)
        {
            Console.WriteLine($"Matière {i + 1}:");
            string matiere = Console.ReadLine();
            
            Console.WriteLine($"Note pour {matiere}:");
            double note = double.Parse(Console.ReadLine());
            
            matieres.Add((matiere, note));
        }
        
        double moyenne = matieres.Average(m => m.note);
        string mention = GetMention(moyenne);
        
        Console.WriteLine($"\nMoyenne: {moyenne:F2}");
        Console.WriteLine($"Mention: {mention}");
    }
    
    static string GetMention(double moyenne)
    {
        if (moyenne >= 16) return "Très Bien";
        if (moyenne >= 14) return "Bien";
        if (moyenne >= 12) return "Assez Bien";
        if (moyenne >= 10) return "Passable";
        return "Insuffisant";
    }
}