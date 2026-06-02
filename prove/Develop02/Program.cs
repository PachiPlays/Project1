using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop2 World!");

        int x = -1;
        

        Journal J = new Journal();


        while(x != 5)
        {
        DateTime dateTime = DateTime.Now;
        string date = dateTime.ToString();

        Console.WriteLine("Please choose one of the following:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Save");
        Console.WriteLine("4. Load");
        Console.WriteLine("5. Quit");

        x = int.Parse(Console.ReadLine());
        switch (x)
        {
        case 1:
        Entry E = new Entry(date);
        string promptUsed = E.GetRandomPrompt();
        Console.WriteLine(promptUsed);
        string userEntry = Console.ReadLine();
        E.SaveEntry(userEntry, promptUsed);
        J.AddEntry(E);
        break;

        case 2:
        J.DisplayEntries();
        break;

        case 3:
        J.SaveJournal();
        break;

        case 4:
        J.LoadNewJournal();
        break;

        case 5:
        x = 5;
        break;

        default:
        Console.WriteLine("Sorry, that doesn't look like a valid entry. Please try again!");
        break;
        }

        }

        Console.WriteLine("Thanks for using the journal! Have a great day!");


    }
}