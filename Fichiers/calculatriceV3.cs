double additionner(double a, double b)
{    
    return a + b;
}

double soustraire(double a, double b)
{
    return a - b;
}

double multiplier(double a, double b)
{
    return a * b;
}

double diviser(double a, double b)
{
    if (b == 0)
    {
        Console.WriteLine("Erreur : Division par zéro.");
        return 0;
    }
    return a / b;
}

char quitter;
while(true)
{
    Console.WriteLine("Bienvenue dans la calculatrice simple !");
    Console.Write("Voulez-vous quitter la calculatrice ? (o/n) : ");
    quitter = Console.ReadKey().KeyChar;
    if (quitter == 'o' || quitter == 'O')
    {
        Console.WriteLine("\nAu revoir !");
        break;
    }
    Console.WriteLine();

Console.Write("Demander nombre 1 : ");
string input1 = Console.ReadLine();

Console.WriteLine("selectionner une opération (+, -, *, /) : ");
string  operateur = (Console.ReadLine() ?? string.Empty).Trim();
Console.Write("Demander nombre 2 : ");
string input2 = Console.ReadLine();

if (!double.TryParse(input2, out double nombre2) || !double.TryParse(input1, out double nombre1))
    {
        Console.WriteLine("Erreur : Veuillez entrer un nombre valide.");
        continue;
    }

    switch (operateur)
    {
        case "+":
            Console.WriteLine($"Résultat : {additionner(nombre1, nombre2)}");
            break;
        case "-":
            Console.WriteLine($"Résultat : {soustraire(nombre1, nombre2)}");
            break;
        case "*":
            Console.WriteLine($"Résultat : {multiplier(nombre1, nombre2)}");
            break;
        case "/":
            Console.WriteLine($"Résultat : {diviser(nombre1, nombre2)}");
            break;
        default:
            Console.WriteLine("Opérateur non valide.");
            break;
    }
}