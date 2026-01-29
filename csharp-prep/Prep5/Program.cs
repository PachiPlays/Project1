using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");

        displayWelcome();
        string userName = promptUserName();

        int number = promptUserNumber();
        int birthYear;
        promptUserBirthYear(out birthYear);

        int numberSquared = squareNumber(number);
        displayResult(userName, numberSquared, birthYear);

    }
    static void displayWelcome()
        {
            Console.WriteLine($"Welcome to the Program!");
        }

        

    static string promptUserName()
        {
            Console.WriteLine("Enter your username: ");
            string userName = Console.ReadLine();
            return userName;
        }

        
        

    static int promptUserNumber()
        {
            Console.WriteLine("What is your favorite integer?");
            int number = int.Parse(Console.ReadLine());

            return number;
        }

        
        

    static void promptUserBirthYear(out int birthYear)
        {
            Console.WriteLine("What is your birth year?");
            birthYear = int.Parse(Console.ReadLine());
            

                
        }
        
        
        
        //Console.WriteLine(birthYear);
        
    static int squareNumber(int number)
        {
            int numberSquared = number * number;
            

            return numberSquared;
        }


       
        

    static void displayResult(string userName, int numberSquared, int birthYear)
        {
            Console.WriteLine($"Hello {userName}! The square of your number is {numberSquared}");

            int ageThisYear = 2026 - birthYear;

            Console.WriteLine($"And this year you will turn: {ageThisYear}");

        }
    

        

    
}