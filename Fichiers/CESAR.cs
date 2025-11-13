using CESAR;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CESAR
{
    public class Start
        {
        public static void Run()
        {
            Console.WriteLine("Choisis une option :");
            Console.WriteLine("1. Chiffrement");
            Console.WriteLine("2. Déchiffrement");
            string choix = Console.ReadLine();
            if (choix == "1")
            {
                Cesar.Chiffrement();
            }
            else if (choix == "2")
            {
                Cesar.Déchiffrement();
            }
            else
            {
                Console.WriteLine("Option invalide. Veuillez choisir 1 ou 2.");
            }
        }
    }


    public class Cesar
    {
        public static void Chiffrement()
        {

            Console.WriteLine("Entre ton mot ou ta phrase :");
            string input = Console.ReadLine();

            // Choisis le décalage
            Console.WriteLine("Choisis le nombre de décalage :");
            int dec = int.Parse(Console.ReadLine());

            // Convertir en ASCII
            List<int> codesASCII = input.Select(c => (int)c).ToList();
            Console.WriteLine("Codes ASCII : " + string.Join(", ", codesASCII));

            // Ajouter 3
            List<int> codesModifies = codesASCII.Select(code => code + dec).ToList();
            Console.WriteLine($"Codes +{dec} : " + string.Join(", ", codesModifies));
            for (int i = 0; i < codesASCII.Count; i++)
            {
                if (codesASCII[i] > 126)
                {
                    codesASCII[i] = codesASCII[i] - 62;
                }
            }

            // Reconvertir en lettres
            string texteChiffre = string.Join("", codesModifies.Select(code => (char)code));

            Console.WriteLine($"\nTexte original : {input}");
            Console.WriteLine($"Texte chiffré : {texteChiffre}");
            Recommencer.Restart();
        }
        public static void Déchiffrement()
        {
            Console.WriteLine("Entre ton mot ou ta phrase :");
            string input = Console.ReadLine();

            // Choisis le décalage
            Console.WriteLine("Choisis le nombre de décalage :");
            int dec = int.Parse(Console.ReadLine());

            // Convertir en ASCII
            List<int> codesASCII = input.Select(c => (int)c).ToList();
            Console.WriteLine("Codes ASCII : " + string.Join(", ", codesASCII));

            // Ajouter 3
            List<int> codesModifies = codesASCII.Select(code => code - dec).ToList();
            Console.WriteLine($"Codes +{dec} : " + string.Join(", ", codesModifies));
            for (int i = 0; i < codesASCII.Count; i++)
            {
                if (codesASCII[i] < 32)
                {
                    codesASCII[i] = codesASCII[i] + 62;
                }
            }

            // Reconvertir en lettres
            string texteChiffre = string.Join("", codesModifies.Select(code => (char)code));

            Console.WriteLine($"\nTexte original : {input}");
            Console.WriteLine($"Texte chiffré : {texteChiffre}");
            Recommencer.Restart();
        }
    }
}

class Recommencer
{
    public static void Restart()
    {
        Console.WriteLine("Veux-tu recommencer ? (O/N)");
        string input = Console.ReadLine();
        switch(input.ToUpper())
        {
            case "O":
                Console.Clear();
                Start.Run();
                break;
            case "N":
                Console.Clear();
                Console.WriteLine("Au revoir !");
                break;
            default:
                Console.WriteLine("Entrée invalide. Veuillez entrer O ou N.");
                Restart();
                break;
        }
    }
}