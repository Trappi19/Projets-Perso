using System;


namespace tets1
{
    public class Calculatrice
    {
        public static void Run()
        {
            Console.WriteLine("=== Calculatrice Simple ===");
            Console.Write("Entrez le premier nombre : ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Entrez le deuxième nombre : ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Sélectionnez une opération (+ - * /) : ");
            string? operation = Console.ReadLine();

            switch (operation)
            {
                case "+":
                    Console.WriteLine($"Résultat: {num1 + num2}");
                    break;
                case "-":
                    Console.WriteLine($"Résultat: {num1 - num2}");
                    break;
                case "*":
                    Console.WriteLine($"Résultat: {num1 * num2}");
                    break;
                case "/":
                    if (num2 != 0)
                        Console.WriteLine($"Résultat: {num1 / num2}");
                    else
                        Console.WriteLine("Erreur: Division par zéro.");
                    break;
                default:
                    Console.WriteLine("Opération invalide.");
                    break;
            }

            Console.WriteLine("\nAppuyez sur une touche pour quitter...");
            Console.ReadKey();
        }
    }
}