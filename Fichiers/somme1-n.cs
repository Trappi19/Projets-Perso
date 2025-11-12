// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Entrez un entier positif n : ");
//         string? input = Console.ReadLine();

//         if (!int.TryParse(input, out int n) || n < 1)
//         {
//             Console.WriteLine("Entrée invalide. Veuillez entrer un entier >= 1.");
//             return;
//         }

//         // Utilisation de la formule arithmétique pour éviter les boucles
//         long sum = (long)n * (n + 1) / 2;
//         Console.WriteLine($"La somme des entiers de 1 à {n} est {sum}.");
//     }
// }