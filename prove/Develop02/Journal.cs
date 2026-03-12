using System.ComponentModel;
using System.IO;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

public class Journal
{
    public string _nameOfUser = "";
    




    public void ReadFile(ref string fileName)
    {
        try
        {
            
        
        
        Console.WriteLine("Reading file...");
        
        string[] lines = System.IO.File.ReadAllLines(fileName);

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
    
    public void LoadNewJournal(ref string fileName)
    {
        Console.WriteLine("Enter the name of the file that you want to load");
        //_fileName = $@"C:\Users\willb\CSE210\Project1\prove\Develop02\{Console.ReadLine()}";
        fileName = Console.ReadLine();
        Console.WriteLine("Loading file... ");
        Console.WriteLine("File loaded!");
        Console.WriteLine("\n");

    }

}