using System;
using log;

namespace calculatrice
{
    public class Calculatrice
    {
        private static log.Log log = new log.Log();
        public static void Run()
        {
            log.CleanLog();
            Console.WriteLine("=== Calculatrice Simple ===");
            Console.Write("Entrez le premier nombre : ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            log.WriteLog("Première saisi enregistré : " + num1);

            Console.Write("Entrez le deuxième nombre : ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            log.WriteLog("2eme saisi enregistré : " + num2);

            Console.Write("Sélectionnez une opération (+ - * /) : ");
            string? operation = Console.ReadLine();
            log.WriteLog("Opération sélectionnée : " + operation);

            switch (operation)
            {
                case "+":
                    double res = (num1 + num2);
                    Console.WriteLine($"Résultat: {res}");
                    break;
                case "-":
                    double res2 = (num1 - num2);
                    Console.WriteLine($"Résultat: {res2}");
                    break;
                case "*":
                    double res3= (num1 * num2);
                    Console.WriteLine($"Résultat: {res3}");
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        double res4 = (num1 / num2);
                        Console.WriteLine($"Résultat: {res4}");
                    }
                    else
                    {
                        log.WriteLog("Erreur de division par zéro.");
                        Console.WriteLine("Erreur: Division par zéro.");
                    }
                    break;
                default:
                    log.WriteLog("Opération invalide entrée.");
                    Console.WriteLine("Opération invalide.");
                    break;
            }

            Console.WriteLine("\nAppuyez sur une touche pour quitter...");
            Console.ReadKey();
        }
    }
}