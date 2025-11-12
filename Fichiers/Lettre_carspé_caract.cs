// using System;

// class BIBOU
// {
//     static void Main()
//     {
//         Console.Write("Saisis un caractère : ");
//         string? input = Console.ReadLine();
//         if (string.IsNullOrEmpty(input))
//         {
//             Console.WriteLine("Aucun caractère saisi.");
//             return;
//         }

//         char c = input[0];
//         Console.WriteLine(c);

//         if (char.IsLetter(c))
//         {
//             Console.WriteLine("C'est une lettre.");
//         }
//         else if (char.IsDigit(c))
//         {
//             Console.WriteLine("C'est un chiffre.");
//         }
//         else
//         {
//             Console.WriteLine("C'est un caractère spécial.");
//         }
//     }
// }