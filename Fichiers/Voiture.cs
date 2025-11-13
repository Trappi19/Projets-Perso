using System;


namespace Test1
{

    public class Voiture
    {
        string model;
        string color;
        private int speed = 0;

        public Voiture(string model, string color)
        {
            this.model = model;
            this.color = color;
        }

        public void Accelerate(int increment)
        {
            speed += increment;
            Console.WriteLine($"La voiture {model} accélère de {increment} km/h. Vitesse actuelle : {speed} km/h.");
        }

        public void Brake(int decrement)
        {
            speed -= decrement;
            if (speed < 0) speed = 0;
            Console.WriteLine($"La voiture {model} freine de {decrement} km/h. Vitesse actuelle : {speed} km/h.");
        }

        public static void Comparaison(Voiture voiture1, Voiture voiture2)
        {
            if (voiture1.speed > voiture2.speed)
                Console.WriteLine($"La voiture {voiture1.model} est plus rapide que la voiture {voiture2.model}.");
            else if (voiture1.speed < voiture2.speed)
                Console.WriteLine($"La voiture {voiture2.model} est plus rapide que la voiture {voiture1.model}.");
            else
                Console.WriteLine($"Les deux voitures {voiture1.model} et {voiture2.model} ont la même vitesse.");

        }
    }
}