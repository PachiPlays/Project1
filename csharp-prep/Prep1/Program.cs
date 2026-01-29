using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");

        Console.Write("Please enter a number: ");
        string user_input = Console.ReadLine();
        Console.WriteLine($"The number you entered was {user_input}");

        Console.WriteLine("What is your first name? ");
        string first_name = Console.ReadLine();
        Console.WriteLine($"What is your last name? ");
        string last_name = Console.ReadLine();
        Console.WriteLine($"Your name is {last_name}, {first_name} {last_name}.");
    
    
    }
}