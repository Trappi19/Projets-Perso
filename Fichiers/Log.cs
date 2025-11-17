using System;
using System.IO;
string message = "This is a log message.";

Console.WriteLine("Début du programme...");

StreamWriter sw = new StreamWriter("log.txt", append: true);
sw.WriteLine($"{DateTime.Now}: {message}");
sw.Close();
Console.WriteLine("Fin du pgramme.");