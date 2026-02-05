using System.ComponentModel;
using System.IO;
using System.Collections.Generic;

public class Journal
{
    public string _nameOfUser = "";
    
    public string _fileName = "";
    List<string> _journalEntries = new List<string>();

    public string _userEntry = "";
    DateTime dateTime = DateTime.Now;

    Prompt promptGenerator = new Prompt();

    public void DisplayPrompt()
    {
        
    Console.WriteLine("Here is your prompt!");
    Console.WriteLine("To finish your entry, enter an empty line!\n");
    promptGenerator.GeneratePrompt();
    
    

    }

    public void NewEntry()
    {
        _journalEntries.Add($"Prompt: {promptGenerator._listOfPrompts[promptGenerator.x]}\n");
        
        do
        {   

            _userEntry = Console.ReadLine();

            if (_userEntry != "")
            {   
                
                _journalEntries.Add(_userEntry);
            }
            else
            {
                Console.WriteLine("Thank you for writing today!");
            }
                


        } while (_userEntry != "");

        


    }

    public void SaveFile()
    {

        try
        {
        if (_fileName == "")
        {
            Console.WriteLine("Enter a name for your file");
            //_fileName = $@"C:\Users\willb\CSE210\Project1\prove\Develop02\{Console.ReadLine()}";
            _fileName = Console.ReadLine();

        }    
        Console.WriteLine("Saving file...");

        using (StreamWriter outputFile = new StreamWriter(_fileName, append: true))
            {   
                

                foreach (string line in _journalEntries)
                {
                    outputFile.WriteLine(line);
                }

                outputFile.WriteLine($"This was written on: {dateTime} by {_nameOfUser}\n");
            }

        
        }

        
            catch (SystemException)
        {
            Console.WriteLine("You need a name for your file! Try again!");
            
        }
    }

    public void ReadFile()
    {
        try
        {
            
        
        
        Console.WriteLine("Reading file...");
        
        string[] lines = System.IO.File.ReadAllLines(_fileName);

        foreach (string line in lines)
        {
        Console.WriteLine(line);   
        }
        Console.WriteLine("\n");

        }

        catch (SystemException)
        {
            Console.WriteLine("You need to load a file to do that first!\n");
        }


    

    }

    public void LoadNewJournal()
    {
        Console.WriteLine("Enter the name of the file that you want to load");
        //_fileName = $@"C:\Users\willb\CSE210\Project1\prove\Develop02\{Console.ReadLine()}";
        _fileName = Console.ReadLine();
        Console.WriteLine("Loading file... ");
        Console.WriteLine("File loaded!");
        Console.WriteLine("\n");
        
    }
}