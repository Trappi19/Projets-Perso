using System;
using System.IO;



namespace log
{

    public class Log
    {
        public void WriteLog(string message)
        {
            Console.WriteLine("Données enregistré");

            StreamWriter sw = new StreamWriter("C:\\Users\\sevan\\Documents\\Mes Documents\\Cesi\\C#\\Projet-Perso\\Fichiers\\Log.txt", append: true);
            sw.WriteLine($"{DateTime.Now}: {message}");
            sw.Close();
        }

        public void CleanLog()
        {
            File.WriteAllText("C:\\Users\\sevan\\Documents\\Mes Documents\\Cesi\\C#\\Projet-Perso\\Fichiers\\Log.txt", string.Empty);
        }
    }
}