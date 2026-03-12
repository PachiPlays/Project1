using System;

class Program
{
    
    static void Main(string[] args)
    {
        
        int userInput = -1;
        string fileName = "";

        Journal journal1 = new Journal();
        Entry entry1 = new Entry();
        
        Console.WriteLine("What is your name? ");
        journal1._nameOfUser = Console.ReadLine();

        while (userInput != 0){

            Console.WriteLine("Welcome to the journal!");

            if (fileName != "")
            {
                Console.WriteLine($"You are currently in the journal called {fileName}!");
            }
            else
            {
                Console.WriteLine("You do not currently have a journal file loaded");
            }
            
            Console.WriteLine("Type 1 to add a new entry to the journal");
            Console.WriteLine("Type 2 to read all entries from the journal");
            Console.WriteLine("Type 3 to save the journal in its current state");
            Console.WriteLine("Type 4 to load a different journal file");
            Console.WriteLine("Type 0 to quit");

            userInput = int.Parse(Console.ReadLine());

            try{
            switch(userInput)
            {
            case 0:

            Console.WriteLine("Thank you!");
            break;

            case 1:
            
            entry1.DisplayPrompt();
            entry1.NewEntry();
            break;

            case 2:

            journal1.ReadFile(ref fileName);


            break;
            
            case 3:
            
            entry1.SaveFile(journal1._nameOfUser, ref fileName);


            break;

            case 4:
            journal1.LoadNewJournal(ref fileName);
            
            break;

            default:
            Console.WriteLine("That's not an option!");

            break;
            }
            
        }
        catch (SystemException)
            {
                Console.WriteLine("That's not a valid entry!");
            }

        }
    }
}