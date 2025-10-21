// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// string name = "Alice";
// Console.WriteLine($"Welcome, {name}!");
// console.ReadLine();
/*int
float
double
char
bool
string*/


// int age = 30;
// float height = 5.7f;
// double weight = 150.5;
// char grade = 'A';
// bool isStudent = false;
// string city = "New York";

// Console.WriteLine($"Age: {age}, Height: {height}, Weight: {weight}, Grade: {grade}, Is Student: {isStudent}, City: {city}");

// if (age > 18)
// {
//     Console.WriteLine("You are an adult.");
// }
// else
// {
//     Console.WriteLine("You are a minor.");
// }

// while (age < 35)
// {
//     Console.WriteLine($"You are still young at {age} years old.");
//     age += 5;
// }

// Console.Write("Donne un nombre");
// double nombre = Convert.ToDouble(Console.ReadLine());
// double res = nombre % 2;
// Console.WriteLine(res);

// if  (res == 0)
// {
//     Console.WriteLine("Le nombre est pair");
// }
// else
// {
//     Console.WriteLine("Le nombre est impair");
// }



// Console.Write("Saisis un caractère : ");
// char c = Console.ReadLine()[0];
// Console.WriteLine(c);

// if (char.IsLetter(c))
// {
//     Console.WriteLine("C'est une lettre.");
// }
// else if (char.IsDigit(c))
// {
//     Console.WriteLine("C'est un chiffre.");
// }
// else
// {
//     Console.WriteLine("C'est un caractère spécial.");
// }


// Console.Write("Saisis une lettre : ");


Console.WriteLine("Entre une chaîne :");
string input = Console.ReadLine();

// Affichage caractère par caractère
Console.WriteLine("Caractères un par un :");
foreach(char c in input)
{
    Console.WriteLine(c);
}
// Inversion de la chaîne
char[] chars = input.ToCharArray();
Array.Reverse(chars);
string inversed = new string(chars);

Console.WriteLine("Chaîne inversée : " + inversed);

foreach(char c in inversed)
{
    Console.WriteLine(c);
}