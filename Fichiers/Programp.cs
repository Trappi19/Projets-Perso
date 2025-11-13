using System;

class Questionnaire
{
    static void Question()
    {
        int age = 30;
        float height = 5.7f;
        double weight = 150.5;
        char grade = 'A';
        bool isStudent = false;
        string city = "New York";

        Console.WriteLine($"Age: {age}, Height: {height}, Weight: {weight}, Grade: {grade}, Is Student: {isStudent}, City: {city}");

        if (age > 18)
        {
            Console.WriteLine("You are an adult.");
        }
        else
        {
            Console.WriteLine("You are a minor.");
        }

        while (age < 35)
        {
            Console.WriteLine($"You are still young at {age} years old.");
            age += 5;
        }
    }
}




