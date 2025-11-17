using System;
using System.IO;
string message = "This is a log message.";

Console.WriteLine("Début du programme...");

StreamWriter sw = new StreamWriter("C:\\Users\\sevan\\Documents\\Mes Documents\\Cesi\\C#\\Projet-Perso\\Fichiers\\Log.txt", append: true);
sw.WriteLine($"{DateTime.Now}: {message}");
sw.Close();
Console.WriteLine("Fin du pgramme.");