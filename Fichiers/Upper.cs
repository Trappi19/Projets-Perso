Console.Write("Donne une chaîne : ");
string input = Console.ReadLine();
string output = "";

foreach (char c in input)
{
    Console.WriteLine(output);
    output += Char.ToUpper(c); // Convertit chaque caractère
}
Console.WriteLine("En majuscule : " + output);