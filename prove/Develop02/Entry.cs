public class Entry{

    
    List<string> _journalEntries = new List<string>();

    public string _userEntry = "";
    DateTime dateTime = DateTime.Now;

    
    Prompt promptGenerator = new Prompt();


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

    public void DisplayPrompt()
    {
        
    Console.WriteLine("Here is your prompt!");
    Console.WriteLine("To finish your entry, enter an empty line!\n");
    promptGenerator.GeneratePrompt();

    }

    public void SaveFile(string userName, ref string _fileName)
    {
        
        

        
            
        

        try
        {

        if (_journalEntries.Count() == 0)
        {
            throw new InvalidOperationException("No current entries");
        }


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

                outputFile.WriteLine($"This was written on: {dateTime} by {userName}\n");
            }

        _journalEntries.Clear();
        //clear the current entries so that it doesn't duplicate them

        }

            catch (InvalidOperationException)
        {
            
            Console.WriteLine("No current entries");
        }
        
            catch (SystemException)
        {
            Console.WriteLine("You need a name for your file! Try again!");
            
        }
        
    }

       
}
